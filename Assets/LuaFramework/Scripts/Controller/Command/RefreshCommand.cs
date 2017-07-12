using UnityEngine;
using System.Collections;
using LuaFramework;

public class RefreshCommand : ControllerCommand {

	public override void Execute(IMessage message) {
		if (!Util.CheckEnvironment()) return;
		//-----------------刷新管理器-----------------------
		AppFacade.Instance.GetManager<LuaManager>(ManagerName.Lua);
		AppFacade.Instance.GetManager<PanelManager>(ManagerName.Panel);
		AppFacade.Instance.GetManager<SoundManager>(ManagerName.Sound);
		AppFacade.Instance.GetManager<TimerManager>(ManagerName.Timer);
		AppFacade.Instance.GetManager<NetworkManager>(ManagerName.Network);
		AppFacade.Instance.GetManager<ResourceManager>(ManagerName.Resource);
		AppFacade.Instance.GetManager<ThreadManager>(ManagerName.Thread);
		AppFacade.Instance.GetManager<ObjectPoolManager>(ManagerName.ObjectPool);
		AppFacade.Instance.GetManager<GameManager>(ManagerName.Game).OnRefresh();
		AppFacade.Instance.GetManager<SceneManager>(ManagerName.Scene);
	}
}