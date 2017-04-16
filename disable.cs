using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class disable : MonoBehaviour {
	public Button Button2;
	public Sprite LetterAA3;
	public Sprite disableSprite;
	//private int counter = 0;
	private int level = 0;

	// Use this for initialization
	void Start () {
		Button2 = GetComponent<Button>();
		//level = GetScore ();
		//level = PlayerData ();
		level = GetPlayerData.levels;

	}
	
	// Update is called once per frame
	public void changeButton () {
		//counter++;
		//if (counter %2 == 0) {
		if(level == 1){
			Button2.image.overrideSprite = LetterAA3;
		} else {
			Button2.image.overrideSprite = disableSprite;
		}
	}
}
