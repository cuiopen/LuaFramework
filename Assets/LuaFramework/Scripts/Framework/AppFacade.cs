using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class AppFacade : Facade {
    private static AppFacade _instance;

    public AppFacade() : base() {

    }

    public static AppFacade Instance
    {
        get {
            if (_instance == null) {
                _instance = new AppFacade();
            }
            return _instance;
        }
    }

    public static AppFacade IsInstance {
        get {
            return _instance;
        }
    }

    override protected void InitFramework() {
        base.InitFramework();
        RegisterCommand(NotiConst.START_UP, typeof(StartUpCommand));
        RegisterCommand(NotiConst.REFRESH, typeof(RefreshCommand));
    }

    /// <summary>
    /// 启动框架 有且只启动一次
    /// </summary>
    public void StartUp() {
        SendMessageCommand(NotiConst.START_UP);
        RemoveMultiCommand(NotiConst.START_UP);
    }

    /// <summary>
    /// 刷新框架 每次切场景 刷新
    /// </summary>
    public void Refresh() {
		SendMessageCommand(NotiConst.REFRESH);
    }
}

