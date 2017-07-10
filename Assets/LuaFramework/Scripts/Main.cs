using UnityEngine;
using System.Collections;

namespace LuaFramework {

    /// <summary>
    /// </summary>
    public class Main : MonoBehaviour {

        void Start() {
        	if (AppFacade.IsInstance != null) {
        		AppFacade.Instance.Refresh();	//刷新游戏
        	} else {
	            AppFacade.Instance.StartUp();   //启动游戏
        	}
        }
    }
}