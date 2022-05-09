using AssemblyCommon;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Hotfix.Common;
using Hotfix.Model;
using LitJson;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Hotfix.SLWH
{
	public enum eAnimal
	{
		Loin = 0,
		Panda = 1,
		Monkey = 2,
		Rabbit = 3,
	}

	public enum eAniColor
	{
		Red = 0,
		Yellow = 1,
		Green = 2,
		Gray = 4,
	}

	public enum eAwardsType
	{
		RLion,
		YLion,
		GLion,
		RPanda,
		YPanda,
		GPanda,
		RMonkey,
		YMonkey,
		GMonkey,
		RRabbit,
		YRabbit,
		GRabbit,

		DaSanYuanLion = 100,
		DaSanYuanPanda,
		DaSanYuanMonkey,
		DaSanYuanRabbit,

		DaSiXiRed = 200,
		DaSiXiYellow,
		DaSiXiGreen,

		Lightingx2 = 301,
		Lightingx3,

		SongDeng = 400,
		CaiJing = 500,

		Big = 600,
		Draw,
		Small
	}

	public class BetItem
	{
		public BetItem(ViewGameScene v, int betID)
		{
			mainV_ = v;
			betID_ = betID;
			Init_();
		}

		public void SetMybet(long bet)
		{
			var txt = txtObj_.FindChildDeeply("selfScore").GetComponent<TextMeshProUGUI>();
			txt.text = bet.ToString();
		}

		public void SetTotalBet(long bet)
		{
			var txt = txtObj_.FindChildDeeply("totalScore").GetComponent<TextMeshProUGUI>();
			txt.text = bet.ToString();
		}

		public void SetFactor(long bet)
		{
			var txt = txtObj_.FindChildDeeply("ratioText").GetComponent<TextMeshProUGUI>();
			txt.text = bet.ToString();
		}

		void Init_()
		{
			//服务器BetID映射到UI名字上
			Dictionary<int, int> mapid = new Dictionary<int, int>();
			mapid.Add(0, 1); mapid.Add(1, 5); mapid.Add(2, 9);
			mapid.Add(3, 2); mapid.Add(4, 6); mapid.Add(5, 10);
			mapid.Add(6, 3); mapid.Add(7, 7); mapid.Add(8, 11);
			mapid.Add(9, 4); mapid.Add(10, 8); mapid.Add(11, 12);
			mapid.Add(12, 13); mapid.Add(13, 14); mapid.Add(14, 15);

			int objID = mapid[betID_];

			anmiObj_ = mainV_.BetStageRoot.FindChildDeeply($"XiazhuAnniu_{objID}");
			objBtn_ = mainV_.BetStageRoot.FindChildDeeply("ButtonRoot").FindChildDeeply($"{objID}");
			txtObj_ = mainV_.BetStageRoot.FindChildDeeply("TextRoot").FindChildDeeply($"{objID}");

			var btn = objBtn_.GetComponent<Button>();
			btn.onClick.AddListener(()=> {
				anmiObj_.StartAnim();
				anmiObj_.StartParticles();

				msg_set_bets_req msg = new msg_set_bets_req();
				msg.pid_ = mainV_.betSelected;
				msg.present_id_ = betID_;
				AppController.ins.network.SendJson((short)GameMultiReqID.msg_set_bets_req, msg);
				
				if (lastBetTurn_ != mainV_.turn_)
					mainV_.lastBets.Clear();

				mainV_.lastBets.Add(msg);
				lastBetTurn_ = mainV_.turn_;
			});
		}
		int lastBetTurn_ = -1;
		int betID_;
		GameObject anmiObj_, objBtn_, txtObj_;
		ViewGameScene mainV_;
	}

	public class Jewel
	{
		public Jewel(ViewGameScene v, GameObject obj)
		{
			mainV_ = v;
			obj_ = obj;
		}

		public void SetColor(int c)
		{
			StopBlink();
			color_ = (eAniColor)c;
			var render = obj_.GetComponent<MeshRenderer>();
			if(color_ == eAniColor.Red)
				render.material = mainV_.matRed.Result;
			else if(color_ == eAniColor.Yellow)
				render.material = mainV_.matYellow.Result;
			else if (color_ == eAniColor.Green)
				render.material = mainV_.matGreen.Result;
			else if (color_ == eAniColor.Gray)
				render.material = mainV_.matRed.Result;
		}

		public void Blink()
		{
			if (color_ == eAniColor.Red)
				obj_.StartAnim("BaoshiFlash_1");
			else if (color_ == eAniColor.Yellow)
				obj_.StartAnim("BaoshiFlash_3");
			else
				obj_.StartAnim("BaoshiFlash_2");

		}

		public void StopBlink()
		{
			obj_.StartAnim("BaoshiFlash");
		}

		GameObject obj_;
		ViewGameScene mainV_;
		eAniColor color_;
	}

	public class Animal
	{
		enum State
		{
			None,
			Idle,
			Jump,
			Dance,
			Round,

		}

		public Animal(GameObject obj, int index, GameObject jumpTarget)
		{
			obj_ = obj;
			jumpTar_ = jumpTarget;
			positionOld_ = obj_.transform.position;
			idles.Add("Idel"); idles.Add("Idel1");
			animal = (eAnimal)(index % 4);
			animal = (eAnimal)(index % 4);
			animal = (eAnimal)(index % 4);
		}
		public Animal(GameObject obj, eAnimal ani)
		{
			obj_ = obj;
			positionOld_ = obj_.transform.position;
			idles.Add("Idel"); idles.Add("Idel1");
			animal = ani;
		}

		public IEnumerator JumpToStage()
		{
			//跳上舞台
			PlayJump();
			var jump = obj_.transform.DOJump(jumpTar_.transform.position, 2, 1, 1.0f);
			yield return jump.WaitForCompletion();

			yield return new WaitForSeconds(0.5f);
			//转身
			RoundBody();
			var rot = obj_.transform.DOLocalRotate(new Vector3(0, 180, 0), 0.5f);
			yield return rot.WaitForCompletion();
			yield return new WaitForSeconds(0.5f);
			//跳舞
			PlayDance();

		}

		public IEnumerator JumpBack()
		{
			//转身准备跳回原来位置
			RoundBody();
			var tPos = positionOld_;
			tPos.y = obj_.transform.position.y;
			var lookAt = obj_.transform.DOLookAt(tPos, 0.5f);
			yield return lookAt.WaitForCompletion();

			//跳回
			PlayJump();
			var jump = obj_.transform.DOJump(positionOld_, 2, 1, 1.0f);
			yield return jump.WaitForCompletion();
			yield return new WaitForSeconds(0.5f);
			//转回原始朝向
			RoundBody();
			var tPos2 = jumpTar_.transform.position;
			tPos2.y = obj_.transform.position.y;
			var lookAt2 = obj_.transform.DOLookAt(tPos2, 0.5f);
			yield return lookAt2.WaitForCompletion();

			PlayIdle();
		}


		public void PlayJump()
		{
			this.StopCor(idleRotID_);
			obj_.StartAnim("Jump");
		}

		IEnumerator DoIdle()
		{
			while(true) {
				string idle = idles.RandomGet();
				float dur = obj_.StartAnim(idle);
				yield return new WaitForSeconds(dur);
			}
		}

		public void PlayIdle()
		{
			idleRotID_ = this.StartCor(DoIdle(), false);
		}

		public void PlayDance()
		{
			this.StopCor(idleRotID_);
			obj_.StartAnim("Victory");
		}

		public void RoundBody()
		{
			this.StopCor(idleRotID_);
			if (animal == eAnimal.Loin) {
				obj_.StartAnim("walk_Lion");
			}
			else if(animal == eAnimal.Panda) {
				obj_.StartAnim("walk_Panda");
			}
			else if (animal == eAnimal.Rabbit) {
				obj_.StartAnim("walk_Rabbit");
			}
			else if (animal == eAnimal.Monkey) {
				obj_.StartAnim("Walk_Monkey");
			}
		}

		public void Stop()
		{
			this.StopCor(-1);
		}

		GameObject obj_, jumpTar_;
		Vector3 positionOld_;
		List<string> idles = new List<string>();
		int idleRotID_ = -1;
		public eAnimal animal;
	}

	public class ViewGameScene : ViewMultiplayerScene
	{
		public ViewGameScene()
		{
			var gm = (GameControllerMultiplayer)AppController.ins.currentApp.game;
			gm.mainView = this;
		}

		protected override void SetLoader()
		{
			var ctrl = (GameController)AppController.ins.currentApp.game;
			LoadScene("Assets/Res/Games/SLWH/Scenes/MainScene.unity", null);
		}

		protected override IEnumerator OnResourceReady()
		{
			yield return base.OnResourceReady();

			LoadAssets<Material>("Assets/Res/Games/SLWH/Dance/Secne_Model/ColorLight/light_Red.mat",
				(t) => {
					matRed = t;
				});

			LoadAssets<Material>("Assets/Res/Games/SLWH/Dance/Secne_Model/ColorLight/light_Green.mat",
				(t) => {
					matGreen = t;
				});

			LoadAssets<Material>("Assets/Res/Games/SLWH/Dance/Secne_Model/ColorLight/light_Yellow.mat",
				(t) => {
					matYellow = t;
				});

			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Result/animalLion.prefab",
				(t) => {
					cachedLion_ = t;
				});

			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Result/animalMonky.prefab",
				(t) => {
					cachedMonkey_ = t;
				});

			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Result/animalPanda.prefab",
				(t) => {
					cachedPanda_ = t;
				});

			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Result/animalRabbit.prefab",
				(t) => {
					cachedRabbit_ = t;
				});

			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Result/animalLion_Gold.prefab",
				(t) => {
					cacheLionGold_ = t;
				});

			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Result/animalMonky_Gold.prefab",
				(t) => {
					cachedMonkeyGold_ = t;
				});
			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Result/animalPanda_Gold.prefab",
				(t) => {
					cachedPandaGold_ = t;
				});

			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Result/animalRabbit_Gold.prefab",
				(t) => {
					cachedRabbitGold_ = t;
				});

			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/UI/Main/BigSmallItem.prefab", (t) => {
				cacheBigSmallItem_ = t;
			});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/color_1.png",
				(t) => {
					cachedRedColor_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/color_2.png",
				(t) => {
					cachedGreenColor_ = t;
				});
			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/color_3.png",
				(t) => {
					cachedYellowColor_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/colorBG_1.png",
				(t) => {
					cachedRedColorBG_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/colorBG_2.png",
				(t) => {
					cachedGreenColorBG_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/colorBG_3.png",
				(t) => {
					cachedYellowColorBG_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/img_1.png",
				(t) => {
					cachedImgLion_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/img_2.png",
				(t) => {
					cachedImgPanda_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/img_3.png",
				(t) => {
					cachedImgMonkey_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/img_4.png",
				(t) => {
					cachedImgRabbit_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Main/type_1_b.png",
				(t) => {
					cachedImgBig_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Main/type_2_b.png",
				(t) => {
					cachedImgDraw_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Main/type_3_b.png",
				(t) => {
					cachedImgSmall_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/type_1.png",
				(t) => {
					cachedImgBigRec_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/type_2.png",
				(t) => {
					cachedImgDrawRec_ = t;
				});

			LoadAssets<Texture2D>("Assets/Res/Games/SLWH/Dance/UI/Result/type_3.png",
				(t) => {
					cachedImgSmallRec_ = t;
				});


			LoadAssets<GameObject>("Assets/Res/Games/SLWH/Dance/Prefabs/Item_Record.prefab",
				(t) => {
					cachedItemRecord_ = t;
				});
			
			yield return Globals.resLoader.WaitForAllTaskCompletion();
			canvas = GameObject.Find("Canvas");

			resultPanel = canvas.FindChildDeeply("ResultPanel");
			BetStageRoot = GameObject.Find("BetStageRoot");
			animalRot = GameObject.Find("Animal_Rotate_Root");
			arrowRot = GameObject.Find("Arrow_Rotate_Root");
			jumpTarget = animalRot.FindChildDeeply("JumpTarget");
			huaBan = GameObject.Find("HuaBan");
			bigSmallViewport = canvas.FindChildDeeply("EnjoyGameScrollView").FindChildDeeply("Viewport");
			recordViewport = canvas.FindChildDeeply("RoadBG").FindChildDeeply("Content");
			var animalIndexs = animalRot.FindChildDeeply("animalIndexs");

			var ColorLightRoot = GameObject.Find("ColorLightRoot");
			for (int i = 1; i <= 24; i++) {
				var obj = ColorLightRoot.FindChildDeeply($"{i}");
				var jew = new Jewel(this, obj);
				jewels_.Add(jew);
			}

			//动物站位分配
			float initDegree = 15 * 360.0f / 24;
			for (int i = 1; i <= 24; i++) {
				GameObject obj;
				//设置位置
				if (i < 10)
					obj = animalIndexs.FindChildDeeply($"0{i}");
				else
					obj = animalIndexs.FindChildDeeply($"{i}");

				float deg = Mathf.Deg2Rad * (initDegree - (360.0f / 24) * (i - 1));

				float x = Mathf.Cos(deg) * 16.0f;
				float z = Mathf.Sin(deg) * 16.0f;
				float y = 9.0f;
				obj.transform.position = new Vector3(x, y, z);
				var lookTo = jumpTarget.transform.position;
				lookTo.y = obj.transform.position.y;
				obj.transform.LookAt(lookTo);

				var animal = new Animal(obj, i - 1, jumpTarget);
				animals_.Add(animal);
				animal.PlayIdle();
			}

			for (int i = 0; i < 15; i++) {
				var bti = new BetItem(this, i);
				betItems_.Add(i, bti);
			}

			//百人类游戏直接进游戏房间
			var handle1 = AppController.ins.network.EnterGameRoom(1, 0);
			yield return handle1;
			if ((int)handle1.Current == 0) {
				ViewToast.Create(LangNetWork.EnterRoomFailed);
			}

			AppController.ins.self.gamePlayer.onDataChanged += OnMyDataChanged;
			OnMyDataChanged(null, null);

			var tog_OpenBet = canvas.FindChildDeeply("tog_OpenBet").GetComponent<Toggle>();
			tog_OpenBet.onValueChanged.AddListener(OnBetClick);

			var betSelectBtns = BetStageRoot.FindChildDeeply("betSelectBtns");
			var SelectEffect = betSelectBtns.FindChildDeeply("SelectEffect");

			for (int i = 0; i <= 5; i++) {
				int bi = i;
				var beti = betSelectBtns.FindChildDeeply(i.ToString());
				var checki = beti.GetComponent<Toggle>();
				checki.onValueChanged.AddListener((seleced) => {
					if (!seleced) return;
					SelectEffect.transform.position = beti.transform.position;
					betSelected = bi + 1; //加压注ID要+1
				});
			}

			var clearBet = betSelectBtns.FindChildDeeply("Clear").GetComponent<Button>();
			clearBet.onClick.AddListener(() => {
				msg_clear_my_bets msg = new msg_clear_my_bets();
				AppController.ins.network.SendJson((short)GameMultiReqID.msg_clear_my_bets, msg);
				myTotalBet_ = 0;
			});

			var continueBet = betSelectBtns.FindChildDeeply("Continue").GetComponent<Button>();
			continueBet.onClick.AddListener(() => {
				this.StartCor(ContinueBet(), true);
			});
		}

		IEnumerator ContinueBet()
		{
			for(int i = 0; i < lastBets.Count; i++) {
				AppController.ins.network.SendJson((short)GameMultiReqID.msg_set_bets_req, lastBets[i]);
				yield return new WaitForSeconds(0.1f);
			}
		}

		void OnBetClick(bool showBet)
		{
			var tog_OpenBet = canvas.FindChildDeeply("tog_OpenBet").GetComponent<Toggle>();

			if (showBet) {
				BetStageRoot.StartDoTweenAnim(false);
			}
			else {
				BetStageRoot.StartDoTweenAnim(true);
			}
			tog_OpenBet.isOn = showBet;
		}

		void OnMyDataChanged(object sender, EventArgs evt)
		{
			var head = canvas.FindChildDeeply("HeadRoot").FindChildDeeply("head").GetComponent<Image>();
			AppController.ins.self.gamePlayer.SetHeadPic(head);

			var frame = canvas.FindChildDeeply("HeadRoot").FindChildDeeply("frame").GetComponent<Image>();
			AppController.ins.self.gamePlayer.SetHeadFrame(frame);

			var nickName = canvas.FindChildDeeply("HeadRoot").FindChildDeeply("nickName").GetComponent<TextMeshProUGUI>();
			nickName.text = AppController.ins.self.gamePlayer.nickName;

			var goldText = canvas.FindChildDeeply("BottomBG").FindChildDeeply("goldText").GetComponent<TextMeshProUGUI>();
			goldText.text = Utils.FormatGoldShow(AppController.ins.self.gamePlayer.items[(int)ITEMID.GOLD]);
		}


		public override void Close()
		{
			foreach (var it in animals_) {
				it.Stop();
			}

			foreach (var it in animalResult_) {
				it.Stop();
			}

			animalResult_.Clear();
			jewels_.Clear();
			betItems_.Clear();
			animals_.Clear();
			AppController.ins.self.gamePlayer.onDataChanged -= OnMyDataChanged;
			base.Close();
		}

		public override void OnNetMsg(int cmd, string json)
		{
			switch (cmd) {
				case (int)GameMultiRspID.msg_send_color: {
					var msg = JsonMapper.ToObject<msg_send_color>(json);
					OnSendColor(msg);
				}
				break;
			}
		}

		IEnumerator DoSetColor(List<int> lst)
		{
			if (!AppController.ins.currentApp.game.isEntering) {
				foreach (var jew in jewels_) {
					jew.SetColor((int)eAniColor.Gray);
					yield return new WaitForSeconds(0.03f);
				}

				int i = 0;
				foreach (var jew in jewels_) {
					jew.SetColor(lst[i]);
					i++;
					yield return new WaitForSeconds(0.03f);
				}
			}
			else {
				int i = 0;
				foreach (var jew in jewels_) {
					jew.SetColor(lst[i]);
					i++;
				}
			}
		}

		private void OnSendColor(msg_send_color msg)
		{
			lstColor = Globals.Split(msg.colors_, ",");
			this.StartCor(DoSetColor(lstColor), true);

			lstRates = Globals.Split(msg.rates_, ",");
			var obj = BetStageRoot.FindChildDeeply("Canvas3D");
			obj = obj.FindChildDeeply("TextRoot");

			for (int i = 0; i < 12; i++) {
				BetItem bi = betItems_[i];
				bi.SetFactor(lstRates[i]);
			}

			MyDebug.LogFormat("Send Color:{0},  rates:{1}", msg.colors_, msg.rates_);
		}

		IEnumerator CountDown_(float t, Text txtCounter)
		{
			float tLeft = t;
			while (tLeft > 0) {
				tLeft -= 1.0f;
				yield return new WaitForSeconds(0.95f);
				if (tLeft < 0.0f) tLeft = 0.0f;
				txtCounter.text = tLeft.ToString();
			}
			yield return 0;
		}

		public IEnumerator ShowBetState_(bool delay)
		{
			if (delay)
				yield return new WaitForSeconds(2.0f);

			foreach (var bi in betItems_) {
				bi.Value.SetMybet(0);
				bi.Value.SetTotalBet(0);
			}

			OnBetClick(true);
		}

		public override void OnStateChange(msg_state_change msg)
		{
			GameControllerBase.GameState st = (GameControllerBase.GameState)int.Parse(msg.change_to_);
			var txtCounter = canvas.FindChildDeeply("TimeCounter").FindChildDeeply("TimeText").GetComponent<Text>();
			var gameState_1 = canvas.FindChildDeeply("gameState_1");
			var gameState_2 = canvas.FindChildDeeply("gameState_2");
			var gameState_3 = canvas.FindChildDeeply("gameState_3");

			gameState_1.SetActive(false);
			gameState_2.SetActive(false);
			gameState_3.SetActive(false);

			if (st == GameControllerBase.GameState.state_wait_start) {
				myTotalBet_ = 0;
				gameState_1.SetActive(true);
				resultPanel.SetActive(false);

				this.StartCor(ShowBetState_(int.Parse(msg.time_left) > 3), false);
			}
			else if (st == GameControllerBase.GameState.state_do_random) {
				gameState_2.SetActive(true);
				resultPanel.SetActive(false);
				OnBetClick(false);
			}
			else if (st == GameControllerBase.GameState.state_rest_end) {
				gameState_3.SetActive(true);
			}

			if (int.Parse(msg.time_total_) > 0)
				stateTimePercent = int.Parse(msg.time_left) * 1.0f / int.Parse(msg.time_total_);

			this.StartCor(CountDown_(int.Parse(msg.time_left), txtCounter), false);
		}

		public override void OnPlayerSetBet(msg_player_setbet msg)
		{
			var bi = betItems_[int.Parse(msg.present_id_)];
			bi.SetTotalBet(long.Parse(msg.max_setted_));
		}

		public override void OnMyBet(msg_my_setbet msg)
		{
			var bi = betItems_[int.Parse(msg.present_id_)];
			bi.SetMybet(long.Parse(msg.my_total_set_));

			myTotalBet_ += long.Parse(msg.set_);
		}

		public override void OnPlayerEnter(msg_player_seat msg)
		{
			base.OnPlayerEnter(msg);
		}

		public override void OnPlayerLeave(msg_player_leave msg)
		{

		}

		GameObject CreateBigSmallItem(int i)
		{
			eAwardsType tp = (eAwardsType)i;
			var bi = cacheBigSmallItem_.Instantiate();
			var img = bi.GetComponent<Image>();
			if (600 + tp == eAwardsType.Big) {
				img.ChangeSprite(cachedImgBig_.Result);
			}
			else if (600 + tp == eAwardsType.Small) {
				img.ChangeSprite(cachedImgSmall_.Result);
			}
			else {
				img.ChangeSprite(cachedImgDraw_.Result);
			}
			return bi;
		}

		IEnumerator DoRandomBigSmall(int newI, float stateTimePercent)
		{
			bigSmallViewport.RemoveAllChildren();
			int count = 30;
			for(int i = lastBigSmall; i < lastBigSmall + 30; i++) {
				int itm = i % 3;
				bigSmallViewport.AddChild(CreateBigSmallItem(itm));
			}
			
			while(lastBigSmall != newI) {
				bigSmallViewport.AddChild(CreateBigSmallItem(lastBigSmall));
				lastBigSmall++;
				lastBigSmall = lastBigSmall % 3;
				count++;
			}
			bigSmallViewport.AddChild(CreateBigSmallItem(lastBigSmall));
			var recTrans = bigSmallViewport.GetComponent<RectTransform>();
			var doMove = recTrans.DOLocalMoveY(count * 120, 9.0f * stateTimePercent);
			doMove.SetEase(Ease.InOutQuint);
			yield return doMove.WaitForCompletion();
			recTrans.DOLocalMoveY(0, 0);
			yield return doMove.WaitForCompletion();

			bigSmallViewport.RemoveAllChildren();
			bigSmallViewport.AddChild(CreateBigSmallItem(lastBigSmall));
		}

		IEnumerator DoRandomResult_(msg_random_result_base msg)
		{
			var pmsg = (msg_random_result_slwh)msg;

			//主中奖类型
			pidMain = (eAwardsType) int.Parse(pmsg.animal_pid_);
			pidSub = (eAwardsType)int.Parse(pmsg.bigsmall_);
			//副中奖类型
			int pidBigsmall = int.Parse(pmsg.bigsmall_);
			//中奖颜色
			int color = int.Parse(pmsg.color_);
			
			int turn = int.Parse(pmsg.turn_);

			//中奖动物列表
			animalIDs = Globals.Split(pmsg.animals_, ",");
			var tweenAnimal = animalRot.transform.DOLocalRotate(new Vector3(0, -720 * 10, 0), 9.0f * stateTimePercent, RotateMode.LocalAxisAdd);
			tweenAnimal.SetEase(Ease.InOutQuint);

			this.StartCor(DoRandomBigSmall(pidBigsmall, stateTimePercent),false);

			List<int> lstAnimals = new List<int>();
			List<int> lstColors = new List<int>();

			for (int i = 0; i < animalIDs.Count; i++) {
				int animal = animalIDs[i];
				int rotUnit = 24 - lastPointerPos;
				rotUnit += animal;
				rotUnit += 24 * 10;
				rotUnit = (int)(rotUnit * 360 / 24.0f);

				float rotTime = 10.0f;
				if (animalIDs.Count > 1) {
					rotTime = 4.0f;
				}
				rotTime *= stateTimePercent;
				var tween = arrowRot.transform.DOLocalRotate(new Vector3(0, rotUnit, 0), rotTime, RotateMode.LocalAxisAdd);
				tween.SetEase(Ease.InOutQuint);
				yield return tween.WaitForCompletion();

				lastPointerPos = animal;

				if(i == 0) huaBan.StartAnim("Open");

				jewels_[animal].Blink();
				yield return new WaitForSeconds(1.0f * stateTimePercent);
				this.StartCor(animals_[animal].JumpToStage(), false);

				if (i != animalIDs.Count - 1) {
					yield return new WaitForSeconds(3.0f * stateTimePercent);
				}
				else {
					yield return new WaitForSeconds(6.0f * stateTimePercent);
				}
				this.StartCor(animals_[animal].JumpBack(), false);
				lstAnimals.Add((int)animals_[animal].animal);
				lstColors.Add(lstColor[animal]);
			}

			if(turn > lastTurn_) {
				var rec = CreateGameRecordItem_(pidMain, pidSub, lstColors, lstAnimals);
				recordViewport.AddChild(rec);
			}
			yield return new WaitForSeconds(1.0f * stateTimePercent);
			huaBan.StartAnim("Close");
		}

		public override void OnRandomResult(msg_random_result_base msg)
		{
			this.StartCor(DoRandomResult_(msg), true);
		}

		GameObject CreateGameRecordItem_(eAwardsType pid, eAwardsType pBigSmall, List<int> color, List<int> animal)
		{
			if (animal.Count == 0 || color.Count == 0) throw new Exception("CreateGameRecordItem error.");

			var obj = cachedItemRecord_.Instantiate();
			var imgBG = obj.GetComponent<Image>();
			SetColorImage_(imgBG, (eAniColor) color[0]);

			var img = obj.FindChildDeeply("animalImg").GetComponent<Image>();
			SetAnimalImage_(img, animals_[animal[0]].animal);

			if (pid >= eAwardsType.DaSanYuanLion && pid <= eAwardsType.DaSanYuanRabbit) {
				var SanYuanRoot = obj.FindChildDeeply("SanYuanRoot");
				for(int i = 1; i <= 3; i++) {
					var obj1 = SanYuanRoot.FindChildDeeply("item_" + i).GetComponent<Image>();
					SetColorImage_(obj1, (eAniColor)i - 1);
					var obj2 = SanYuanRoot.FindChildDeeply("animal_" + i).GetComponent<Image>();
					SetAnimalImage_(obj2, animals_[animal[0]].animal);
				}
			}
			else if(pid >= eAwardsType.DaSiXiRed && pid <= eAwardsType.DaSiXiGreen) {
				var SiXiRoot = obj.FindChildDeeply("SiXiRoot");
				for (int i = 1; i <= 4; i++) {
					var obj1 = SiXiRoot.FindChildDeeply("item_" + i).GetComponent<Image>();
					SetColorImage_(obj1, (eAniColor)color[0]);
					var obj2 = SiXiRoot.FindChildDeeply("animal_" + i).GetComponent<Image>();
					SetAnimalImage_(obj2, animals_[i - 1].animal);
				}
			}
			else if(pid >= eAwardsType.Lightingx2 && pid <= eAwardsType.Lightingx3) {
				var ShanDianRoot = obj.FindChildDeeply("ShanDianRoot");
				ShanDianRoot.SetActive(true);
				var txt = ShanDianRoot.GetComponentInChildren<TextMeshProUGUI>();
				if(pid == eAwardsType.Lightingx2)
					txt.text = "2";
				else
					txt.text = "3";
			}
			else if(pid == eAwardsType.SongDeng) {
				var SongDengRoot = obj.FindChildDeeply("SongDengRoot");
				SongDengRoot.SetActive(true);
				if(color.Count > 1) {
					var colorImg = SongDengRoot.FindChildDeeply("colorImg").GetComponent<Image>();
					SetColorImage_(colorImg, (eAniColor)color[1]);
				}
				
				if(animal.Count > 1) {
					var animalImg = SongDengRoot.FindChildDeeply("animalImg").GetComponent<Image>();
					SetAnimalImage_(animalImg, (eAnimal)animals_[animal[1]].animal);
				}
			}
			else if (pid == eAwardsType.CaiJing) {
				var CaiJinRoot = obj.FindChildDeeply("CaiJinRoot");
				CaiJinRoot.SetActive(true);
			}

			var img2 = obj.FindChildDeeply("enjoyTypeImg1").GetComponent<Image>();
			SetBigSmallRecImage_(img2, pBigSmall);
			return obj;
		}

		public override void OnLastRandomResult(msg_last_random_base msg)
		{
			var pmsg = (msg_last_random_slwh)msg;
			MyDebug.LogFormat("OnLastRandomResult:animals{0},  color_:{1}", pmsg.ani_, pmsg.color_);
			List<int> pids = Globals.Split(pmsg.pids_, ",");
			List<int> bigsmalls = Globals.Split(pmsg.bigsmall_, ",");
			List<int> animals = Globals.Split(pmsg.ani_, ",");
			List<int> colors = Globals.Split(pmsg.color_, ",");
			List<int> turns = Globals.Split(pmsg.turn_, ",");

			if (pids.Count == 0 || bigsmalls.Count == 0 || animals_.Count == 0 || turns.Count == 0) return;

			if (bigsmalls.Count > 0) {
				lastBigSmall = bigsmalls.Last();
				bigSmallViewport.AddChild(CreateBigSmallItem(lastBigSmall));
			}

			//服务器是最新的在新前面,需要倒过来显示
			for (int i = pids.Count - 1; i >= 0; i--) {
				List<int> c1 = new List<int>(); c1.Add(colors[i]);
				List<int> ani = new List<int>(); ani.Add(animals[i]);
				var rec = CreateGameRecordItem_((eAwardsType) pids[i], (eAwardsType) bigsmalls[i], c1, ani);
				recordViewport.AddChild(rec);
			}
			lastTurn_ = turns.First();
			var gameCountText = canvas.FindChildDeeply("gameCountText").GetComponent<TextMeshProUGUI>();
			gameCountText.text = lastTurn_.ToString();
		}

		public override void OnBankDepositChanged(msg_banker_deposit_change msg)
		{
			
		}

		public override void OnBankPromote(msg_banker_promote msg)
		{
			
		}

		public override void OnGameInfo(msg_game_info msg)
		{
			var gameCountText = canvas.FindChildDeeply("gameCountText").GetComponent<TextMeshProUGUI>();
			gameCountText.text = msg.turn_;
			turn_ = int.Parse(msg.turn_);

			List<int> pids = Globals.Split(msg.pids_, ",");
			List<int> counts = Globals.Split(msg.counts_, ",");
			int sanYuanC = 0, siXiC = 0, caiJingC = 0, songDengC = 0, sanDianC = 0;
			for(int i = 0; i < pids.Count; i++) {
				if (pids[i] >= (int)eAwardsType.DaSanYuanLion && pids[i] <= (int)eAwardsType.DaSanYuanRabbit) {
					sanYuanC += counts[i];
				}
				else if(pids[i] >= (int) eAwardsType.DaSiXiRed && pids[i] <= (int)eAwardsType.DaSiXiGreen) {
					siXiC += counts[i];
				}
				else if(pids[i] >= (int) eAwardsType.Lightingx2 && pids[i] <= (int)eAwardsType.Lightingx3) {
					sanDianC += counts[i];
				}
				else if(pids[i] == (int)eAwardsType.CaiJing) {
					caiJingC += counts[i];
				}
				else if(pids[i] == (int)eAwardsType.SongDeng) {
					songDengC += counts[i];
				}
			}

			var txts = canvas.FindChildDeeply("Texts");
			var sixiText = txts.FindChildDeeply("sixiText").GetComponent<TextMeshProUGUI>();
			sixiText.text = Language.DaSiXi + "X" + siXiC;

			var sanyuanText = txts.FindChildDeeply("sanyuanText").GetComponent<TextMeshProUGUI>();
			sanyuanText.text = Language.DaSanYuan + "X" + sanYuanC;

			var songDengText = txts.FindChildDeeply("songDengText").GetComponent<TextMeshProUGUI>();
			songDengText.text = Language.SondDeng + "X" + songDengC;

			var caiJinText = txts.FindChildDeeply("caiJinText").GetComponent<TextMeshProUGUI>();
			caiJinText.text = Language.CaiJing + "X" + caiJingC;

			var sanDianText = txts.FindChildDeeply("sanDianText").GetComponent<TextMeshProUGUI>();
			sanDianText.text = Language.SanDian + "X" + sanDianC;

			var allText = txts.FindChildDeeply("allText").GetComponent<TextMeshProUGUI>();
			allText.text = Language.TotalTurn + "X" + turn_;
		}

		void SetBigSmallRecImage_(Image img, eAwardsType item)
		{
			if((600 + item) == eAwardsType.Big) {
				img.ChangeSprite(cachedImgBigRec_.Result);
			}
			else if ((600 + item) == eAwardsType.Small) {
				img.ChangeSprite(cachedImgSmallRec_.Result);
			}
			else {
				img.ChangeSprite(cachedImgDrawRec_.Result);
			}
		}

		void SetAnimalImage_(Image img1, eAnimal animal)
		{
			if (animal == eAnimal.Loin)
				img1.ChangeSprite(cachedImgLion_.Result);
			else if (animal == eAnimal.Panda)
				img1.ChangeSprite(cachedImgPanda_.Result);
			else if (animal == eAnimal.Monkey)
				img1.ChangeSprite(cachedImgMonkey_.Result);
			else
				img1.ChangeSprite(cachedImgRabbit_.Result);
		}

		void SetColorImage_(Image imgBG, eAniColor color)
		{
			if (color == eAniColor.Red) {
				imgBG.ChangeSprite(cachedRedColorBG_.Result);
			}
			else if (color == eAniColor.Yellow) {
				imgBG.ChangeSprite(cachedYellowColorBG_.Result);
			}
			else {
				imgBG.ChangeSprite(cachedGreenColorBG_.Result);
			}
		}

		public override void OnGameReport(msg_game_report msg)
		{
			resultPanel.SetActive(true);

			var ResuletScrollView = resultPanel.FindChildDeeply("ResuletScrollView");
			var cont = ResuletScrollView.FindChildDeeply("Content");
			
			cont.RemoveAllChildren();
			
			foreach(var it in animalResult_) {
				it.Stop();
			}
			animalResult_.Clear();

			bool bGold = pidMain >= eAwardsType.DaSanYuanLion;
			int ratio = 0;
			for (int i = 0; i < animalIDs.Count; i++) {
				eAnimal animal = animals_[animalIDs[i]].animal;
				eAniColor color = (eAniColor)lstColor[animalIDs[i]];
				ratio = lstRates[(int)animal * 3 + (int)color];
				GameObject objAnimal;
				
				if(animal == eAnimal.Loin) {
					if (bGold)
						objAnimal = cacheLionGold_.Instantiate();
					else
						objAnimal = cachedLion_.Instantiate();
				}
				else if(animal == eAnimal.Monkey){
					if (bGold)
						objAnimal = cachedMonkeyGold_.Instantiate();
					else
						objAnimal = cachedMonkey_.Instantiate();
				}
				else if(animal == eAnimal.Panda) {
					if (bGold)
						objAnimal = cachedPandaGold_.Instantiate();
					else
						objAnimal = cachedPanda_.Instantiate();
				}
				else {
					if (bGold)
						objAnimal = cachedRabbitGold_.Instantiate();
					else
						objAnimal = cachedRabbit_.Instantiate();
				}

				var objColor = objAnimal.FindChildDeeply("color").GetComponent<Image>();
				var ratioTxt = objAnimal.FindChildDeeply("ratioText").GetComponent<TextMeshProUGUI>();
				cont.AddChild(objAnimal);

				Animal anim = new Animal(objAnimal, animal);
				animalResult_.Add(anim);
				anim.PlayIdle();

				ratioTxt.text = "X" + ratio;

				if (color == eAniColor.Red) {
					objColor.ChangeSprite(cachedRedColor_.Result);
				}
				else if(color == eAniColor.Green) {
					objColor.ChangeSprite(cachedGreenColor_.Result);
				}
				else
					objColor.ChangeSprite(cachedYellowColor_.Result);
			}

			var spine_stage = resultPanel.FindChildDeeply("spine_stage");
			var sk = spine_stage.GetComponent<SkeletonGraphic>();
			sk.AnimationState.SetAnimation(0, "animation", true);

			var betText = resultPanel.FindChildDeeply("betText").GetComponent<Text>();
			betText.text = msg.pay_;
			var winText = resultPanel.FindChildDeeply("winText").GetComponent<Text>();
			winText.text = msg.actual_win_;
			var winEnjoyGame = canvas.FindChildDeeply("winEnjoyGame");
			var winColorBG_1 = winEnjoyGame.FindChildDeeply("winColorBG_1");
			var winColorBG_2 = winEnjoyGame.FindChildDeeply("winColorBG_2");
			var winColorBG_3 = winEnjoyGame.FindChildDeeply("winColorBG_3");
			winColorBG_1.SetActive(false); 
			winColorBG_2.SetActive(false); 
			winColorBG_3.SetActive(false);
			var ratio2 = winEnjoyGame.FindChildDeeply("ratioText").GetComponent<TextMeshProUGUI>();
			if (pidSub == eAwardsType.Big - 600) {
				winColorBG_1.SetActive(true);
				ratio2.text = "X2";
			}
			else if(pidSub == eAwardsType.Small - 600) {
				winColorBG_3.SetActive(true);
				ratio2.text = "X2";
			}
			else {
				winColorBG_2.SetActive(true);
				ratio2.text = "X12";
			}

			var winAnimal = resultPanel.FindChildDeeply("winAnimal");
			var winSanYuan = resultPanel.FindChildDeeply("winSanYuan");
			var winSiXi = resultPanel.FindChildDeeply("winSiXi");
			var winShandian = resultPanel.FindChildDeeply("winShandian");
			var winCaiJin = resultPanel.FindChildDeeply("winCaiJin");
			var winSongDeng = resultPanel.FindChildDeeply("winSongDeng");
			winAnimal.SetActive(false);
			winSanYuan.SetActive(false);
			winSiXi.SetActive(false);
			winShandian.SetActive(false);
			winCaiJin.SetActive(false);
			winSongDeng.SetActive(false);

			if (pidMain >= eAwardsType.DaSanYuanLion && pidMain < eAwardsType.DaSiXiRed) {
				winSanYuan.SetActive(true);
			}
			else if (pidMain >= eAwardsType.DaSiXiRed && pidMain < eAwardsType.Lightingx2) {
				winSiXi.SetActive(true);
			}
			else if (pidMain == eAwardsType.SongDeng) {
				winSongDeng.SetActive(true);
			}
			else if (pidMain == eAwardsType.CaiJing) {
				winCaiJin.SetActive(true);
			}
			else {
				winAnimal.SetActive(true);
				eAnimal animal = animals_[animalIDs[0]].animal;
				eAniColor color = (eAniColor)lstColor[animalIDs[0]];
				var pivot = new Vector2(0.5f, 0.5f);
				var imgBG = winAnimal.FindChildDeeply("winColorBG").GetComponent<Image>();
				SetColorImage_(imgBG, color);

				var img1 = winAnimal.FindChildDeeply("animalImg").GetComponent<Image>();
				SetAnimalImage_(img1, animal);

				var ratio3 = winAnimal.FindChildDeeply("ratioText").GetComponent<TextMeshProUGUI>();
				ratio3.text = "X" + ratio;
			}
		}

		public override void OnGoldChange(msg_deposit_change2 msg)
		{
			int pos = AppController.ins.self.gamePlayer.serverPos;
			if (int.Parse(msg.pos_) == pos) {
				if(int.Parse(msg.display_type_) == (int)msg_deposit_change2.dp.display_type_sync_gold) {
					AppController.ins.self.gamePlayer.items.SetKeyVal((int)ITEMID.GOLD, long.Parse(msg.credits_));
					AppController.ins.self.gamePlayer.DispatchDataChanged();
				}
			}
		}

		public override void OnGoldChange(msg_currency_change msg)
		{
			if(msg.why_ == "0") {
				AppController.ins.self.gamePlayer.items.SetKeyVal((int)ITEMID.GOLD, long.Parse(msg.credits_));
				AppController.ins.self.gamePlayer.DispatchDataChanged();
			}

		}
		long myTotalBet_
		{
			get {
				return myTotalBet__;
			}
			set {
				myTotalBet__ = value;
				var betText = canvas.FindChildDeeply("BottomBG").FindChildDeeply("betText").GetComponent<TextMeshProUGUI>();
				betText.text = Utils.FormatGoldShow(myTotalBet__);
			}
		}

		public AddressablesLoader.LoadTask<Material>  matRed, matGreen, matYellow;
		public GameObject BetStageRoot, animalRot, arrowRot, jumpTarget, canvas, resultPanel, huaBan, bigSmallViewport, recordViewport;
		public int betSelected = 1, turn_;
		public List<msg_set_bets_req> lastBets = new List<msg_set_bets_req>();
		List<Jewel> jewels_ = new List<Jewel>();
		List<Animal> animals_ = new List<Animal>();
		Dictionary<int, BetItem> betItems_ = new Dictionary<int, BetItem>();

		int lastPointerPos = 0, lastBigSmall = 0, lastTurn_ = 0;
		AddressablesLoader.LoadTask<GameObject> cachedLion_, cacheLionGold_, cachedPanda_, cachedPandaGold_, 
			cachedMonkey_, cachedMonkeyGold_, cachedRabbit_, cachedRabbitGold_, cacheBigSmallItem_,
			cachedItemRecord_;

		AddressablesLoader.LoadTask<Texture2D> cachedRedColor_, cachedGreenColor_, cachedYellowColor_,
			cachedRedColorBG_, cachedGreenColorBG_, cachedYellowColorBG_,
			cachedImgLion_, cachedImgPanda_, cachedImgMonkey_, cachedImgRabbit_,
			cachedImgBig_, cachedImgDraw_, cachedImgSmall_, cachedImgBigRec_, cachedImgDrawRec_, cachedImgSmallRec_;

		List<int> lstColor, lstRates, animalIDs;
		eAwardsType pidMain, pidSub;

		List<Animal> animalResult_ = new List<Animal>();
		float stateTimePercent = 0.0f;
		long myTotalBet__ = 0;
	}
}
