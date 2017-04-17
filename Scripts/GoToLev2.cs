/*
 * GoToLev2.cs
 * @author Dariusz Hanuszewicz
 * 14.04.2017
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToLev2 : MonoBehaviour {
	public Button ButtonStart;

	public void ButLvl2 () {
		Debug.Log ("*************************************************************************");
		SceneManager.LoadScene ("Level2", LoadSceneMode.Single);
	}
}