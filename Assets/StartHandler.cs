using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartHandler : MonoBehaviour {

	public void StartGame()
	{

		//ScenceManager.LoadScence (1);
		//	SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
		SceneManager.LoadScene(1);
	}
}
