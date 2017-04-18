/*
 * levelThree.cs
 * @author Carl Moylan 15014355
 * 13.04.2017
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelThree : MonoBehaviour {

	public Button Button3;


	public void ButtonThree () {
		SceneManager.LoadScene ("Level3", LoadSceneMode.Single);
	}

}