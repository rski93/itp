/*
 * HowToPlay2.cs
 * @author Carl Moylan 15014355
 * 18.04.2017
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlay2 : MonoBehaviour {

	public Button ButtonHowToPlay2;


	public void ButHowToPlay2 () {
		SceneManager.LoadScene ("HowToPlay2", LoadSceneMode.Single);
	}
}
