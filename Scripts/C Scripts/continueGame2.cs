﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class continueGame2 : MonoBehaviour {

	public Button ButtonContinueGame3;


	public void ButContinueGame3 () {
		SceneManager.LoadScene ("ContinueGame3", LoadSceneMode.Single);
	}
}
