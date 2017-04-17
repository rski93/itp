using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class continueGame : MonoBehaviour {

	public Button ButtonContinueGame2;


	public void ButContinueGame2 () {
		SceneManager.LoadScene ("ContinueGame2", LoadSceneMode.Single);
	}
}
