using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitHandler : MonoBehaviour 
{

	public void QuitGame()
	{

		print ("Thank you!");
		Application.Quit ();
	}
}
