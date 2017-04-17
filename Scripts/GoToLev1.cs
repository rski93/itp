/*
 * GoToLev1.cs
 * @author Dariusz Hanuszewicz
 * 10.03.2017
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToLev1 : MonoBehaviour {
	public Button ButtonStart;

	public void ButStart () {
		SceneManager.LoadScene ("Level1", LoadSceneMode.Single);
	}
}