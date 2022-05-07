using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OSAHelper {
    public class OSAScrollView : OSA<Param, ItemViewHolder> {



        public object exView = null;
        public Action<object> StartCallback = null;
        public Action<object> UpdateCallback = null;
        public Action<object[]> UpdateViewsHolderCallback = null;
        public Action<object[]> OnBeforeRecycleOrDisableViewsHolderCallback = null;
        public Action<object[]> RebuildLayoutDueToScrollViewSizeChangeCallback = null;
        public Action<object[]> ChangeItemsCountCallback = null;
        public Action<object> DisposeCallback = null;

        public Action<object[]> OnItemHeightChangedPreTwinPassCallback = null;
        public Action<object[]> OnItemWidthChangedPreTwinPassCallback = null;
        public Action<object[]> OnItemIndexChangedDueInsertOrRemoveCallback = null;


        Func<object[], ItemViewHolder> _CreateViewsHolderCallback;
        public Func<object[], ItemViewHolder> CreateViewsHolderCallback { get {
                return _CreateViewsHolderCallback;
            } set {
                if (!iswake) {
                    Debug.LogWarning($"请先保证OSA的物体是激活的: {gameObject.name}");
                }
                _CreateViewsHolderCallback = value;
            } }

        bool iswake = false;
        protected override void Awake() {
            iswake = true;
            base.Awake();

        }

        protected override void Start() {
            StartCallback?.Invoke(this);
            base.Start();
        }

        protected override void Update() {
            base.Update();
            UpdateCallback?.Invoke(this);
        }

        protected override void UpdateViewsHolder(ItemViewHolder newOrRecycled) {
            UpdateViewsHolderCallback?.Invoke(new object[] { this, newOrRecycled });
        }

        protected override ItemViewHolder CreateViewsHolder(int itemIndex) {
            return CreateViewsHolderCallback?.Invoke(new object[] { this, itemIndex });
        }
        protected override void OnItemHeightChangedPreTwinPass(ItemViewHolder viewsHolder) {
            base.OnItemHeightChangedPreTwinPass(viewsHolder);
            OnItemHeightChangedPreTwinPassCallback?.Invoke(new object[] { this, viewsHolder.ItemIndex });
        }

        protected override void OnItemWidthChangedPreTwinPass(ItemViewHolder viewsHolder) {
            base.OnItemWidthChangedPreTwinPass(viewsHolder);
            OnItemWidthChangedPreTwinPassCallback?.Invoke(new object[] { this, viewsHolder.ItemIndex });
        }

        protected override void OnBeforeRecycleOrDisableViewsHolder(ItemViewHolder inRecycleBinOrVisible, int newItemIndex) {
            base.OnBeforeRecycleOrDisableViewsHolder(inRecycleBinOrVisible, newItemIndex);
            OnBeforeRecycleOrDisableViewsHolderCallback?.Invoke(new object[] { this, inRecycleBinOrVisible, newItemIndex });
        }

        protected override void RebuildLayoutDueToScrollViewSizeChange() {
            base.RebuildLayoutDueToScrollViewSizeChange();
            RebuildLayoutDueToScrollViewSizeChangeCallback?.Invoke(new object[] { this });
        }

        public override void ChangeItemsCount(ItemCountChangeMode changeMode, int itemsCount, int indexIfInsertingOrRemoving = -1, bool contentPanelEndEdgeStationary = false, bool keepVelocity = false) {
            base.ChangeItemsCount(changeMode, itemsCount, indexIfInsertingOrRemoving, contentPanelEndEdgeStationary, keepVelocity);
            ChangeItemsCountCallback?.Invoke(new object[] { this, changeMode, itemsCount, indexIfInsertingOrRemoving, contentPanelEndEdgeStationary, keepVelocity });
        }

        protected override void OnItemIndexChangedDueInsertOrRemove(ItemViewHolder shiftedViewsHolder, int oldIndex, bool wasInsert, int removeOrInsertIndex) {
            base.OnItemIndexChangedDueInsertOrRemove(shiftedViewsHolder, oldIndex, wasInsert, removeOrInsertIndex);
            OnItemIndexChangedDueInsertOrRemoveCallback?.Invoke(new object[] { this, shiftedViewsHolder, oldIndex, wasInsert, removeOrInsertIndex });

        }
        protected override void Dispose() {
            base.Dispose();
            DisposeCallback?.Invoke(this);
            CreateViewsHolderCallback = null;
            exView = null;
            StartCallback = null;
            UpdateCallback = null;
            UpdateViewsHolderCallback = null;
            OnBeforeRecycleOrDisableViewsHolderCallback = null;
            RebuildLayoutDueToScrollViewSizeChangeCallback = null;
            ChangeItemsCountCallback = null;
            DisposeCallback = null;

            OnItemHeightChangedPreTwinPassCallback = null;
            OnItemWidthChangedPreTwinPassCallback = null;
            OnItemIndexChangedDueInsertOrRemoveCallback = null;
        }
        //
        public void ScheduleComputeTwinPass(bool preferContentEndEdgeStationaryIfSizeChanges = false) {
            ScheduleComputeVisibilityTwinPass(preferContentEndEdgeStationaryIfSizeChanges);
        }


    }

    [Serializable]
    public class Param : BaseParamsWithPrefab {

    }

    public class ItemViewHolder : BaseItemViewsHolder {
        public object bindData = null;
        public Action<object[]> UpdateFromModelCallback = null;
        public Action DecativePopupAnimation = null;
        public Action<object[]> CollectViewsCallback = null;
        public Action<object[]> MarkForRebuildCallback = null;
        public Action<object[]> UnmarkForRebuildCallback = null;


        public override void CollectViews() {
            base.CollectViews();
            CollectViewsCallback?.Invoke(new object[] { this });
        }

        public override void MarkForRebuild() {
            base.MarkForRebuild();
            MarkForRebuildCallback?.Invoke(new object[] { this });
        }

        public override void UnmarkForRebuild() {
            base.UnmarkForRebuild();
            UnmarkForRebuildCallback?.Invoke(new object[] { this });
        }

        public override void OnBeforeDestroy() {
            base.OnBeforeDestroy();
            bindData = null;
            UpdateFromModelCallback = null;
            DecativePopupAnimation = null;
            CollectViewsCallback = null;
            MarkForRebuildCallback = null;
            UnmarkForRebuildCallback = null;
        }
    }
}
