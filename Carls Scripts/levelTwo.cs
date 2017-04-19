/*
 * levelTwo.cs
 * @author Carl Moylan 15014355
 * 12.04.2017
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelTwo : MonoBehaviour {

	public Button Button2;


	public void ButtonTwo () {
		SceneManager.LoadScene ("Level2", LoadSceneMode.Single);
	}
		
}