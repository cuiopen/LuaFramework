using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace LuaFramework {
	public class SceneManager : Manager {
		private UnityEngine.SceneManagement.SceneManager manager;

		void Awake() {
		}

		public void ChangeScene(string name) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (name);
		}

		public string GetCurSceneName(){
			return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
		}
	}
}