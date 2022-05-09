using AssemblyCommon;
using Hotfix.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Hotfix.SLWH
{

	public class AShower : IShowDownloadProgress
	{
		public ViewLoading vl_;
		public void Progress(long downed, long totalLength)
		{
			if(vl_.slider != null) vl_.slider.maxValue = totalLength;
			if (vl_.slider != null) vl_.slider.value = downed;
		}

		public void Desc(string desc)
		{
			if (vl_.txt != null) vl_.txt.text = desc;
		}

		public void SetState(DownloadState st)
		{

		}

	}

	public class ViewLoading : ViewBase
	{
		public Slider slider;
		public Text txt;
		AShower progress2_ = new AShower();

		public ViewLoading()
		{
			progress2_.vl_ = this;
			progress = progress2_;
		}

		protected override void SetLoader()
		{
			LoadScene("Assets/Res/Games/SLWH/Scenes/LoadingScene.unity", null);
		}

		protected override IEnumerator OnResourceReady()
		{
			yield return base.OnResourceReady();
			var canvas = GameObject.Find("Canvas");
			slider = canvas.FindChildDeeply("Slider").GetComponent<Slider>();
			txt = canvas.FindChildDeeply("Text").GetComponent<Text>();
		}

	}
}
