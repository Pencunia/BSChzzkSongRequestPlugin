﻿using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using ChzzkChat.Configuration;
using ChzzkChat.SongRequest;
using HMUI;
using System;
using System.Collections.Generic;
using BeatSaberMarkupLanguage.Components;
using System.Threading;

namespace ChzzkChat.UI
{
    internal class LeftPanelController : BSMLAutomaticViewController
    {
        private RequestListControl requestListControl = new RequestListControl();
        
        [UIValue("requestQueState")]
        public bool RequestQueState
        {
            get => PluginConfig.Instance.RequestQueOpen;
            set
            {
                PluginConfig.Instance.RequestQueOpen = value;
                NotifyPropertyChanged();
            }
        }

        #region RequestList
        [UIComponent("request-list")]
        public CustomCellListTableData customRequestList = null;
        public Action<Request> clickedRequest;

        private int selectedIdx = -1;
        bool reloadData = true;

        [UIValue("request-list-data")]
        public List<object> requestListData
        {
            get
            {
                List<object> list = new List<object>();

                if (PluginConfig.Instance != null)
                {
                    foreach (var i in PluginConfig.Instance.RequestList)
                    {
                        list.Add((object)i);
                    }
                }

                return list;
            }
        }

        [UIAction("request-click")]
        void RequestClick(TableView tableVeiw, Request request)
        {
            selectedIdx = requestListData.FindIndex(song => song.Equals(request));
            customRequestList.tableView.SelectCellWithIdx(selectedIdx);

            ListUpdate();
        }

        [UIAction("on-click-accept-btn")]
        private void OnClickAcceptBtn()
        {
            if (selectedIdx > -1)
            {
                requestListControl.AcceptRequest(selectedIdx);
            }
        }

        [UIAction("on-click-decline-btn")]
        private void OnClickDeclineBtn()
        {
            if (selectedIdx > -1)
            {
                requestListControl.DeclineRequest(selectedIdx);
                selectedIdx = -1;
                customRequestList.tableView.ClearSelection();

                NotifyPropertyChanged();
                customRequestList.tableView.ReloadData();
            }
        }

        public void ListUpdate()
        {
            if (requestListData == null || customRequestList?.tableView == null)
            {
                return;
            }

            if (selectedIdx > -1)
            {
                customRequestList.tableView?.SelectCellWithIdx(selectedIdx);
            }

            if (reloadData)
            {
                customRequestList.data = requestListData;

                customRequestList.tableView?.Invoke("ReloadData",0.1f);
            }
        }

        #endregion RequestList
    }
}
