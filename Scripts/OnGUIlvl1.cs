/*
 * OnGUIlvl1.cs
 * @author Dariusz Hanuszewicz
 * 15.04.2017
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnGUIlvl1 : MonoBehaviour {
	public static float caughtLetters= 0;

	public Texture aTexture0;
	public Texture aTexture1;

	public AudioClip mySound;
	public AudioSource mySource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Letter") 
		{
			Destroy (other.gameObject);
			caughtLetters += 1;
			mySource.clip = mySound;
			mySource.Play();
		}
	}
	void OnGUI()
	{
		//GUI.contentColor = Color.black;
		//GUI.Label (new Rect (800, 100, 200, 50), "Caught Letters: " + caughtLetters.ToString ());

		GUI.DrawTexture (new Rect (200, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);
		GUI.DrawTexture (new Rect (250, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);
		GUI.DrawTexture (new Rect (300, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);
		GUI.DrawTexture (new Rect (350, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);
		GUI.DrawTexture (new Rect (400, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);
		GUI.DrawTexture (new Rect (450, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);
		GUI.DrawTexture (new Rect (500, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);
		GUI.DrawTexture (new Rect (550, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);
		GUI.DrawTexture (new Rect (600, 20, 40, 40), aTexture0, ScaleMode.ScaleToFit, true, 1.0F);

		if (caughtLetters>=1) {
			GUI.DrawTexture (new Rect (200, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);

		}
		if (caughtLetters>=2) {
			GUI.DrawTexture (new Rect (250, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);
		}
		if (caughtLetters>=3) {
			GUI.DrawTexture (new Rect (300, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);
		}
		if (caughtLetters>=4) {
			GUI.DrawTexture (new Rect (350, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);
		}
		if (caughtLetters>=5) {
			GUI.DrawTexture (new Rect (400, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);
		}
		if (caughtLetters>=6) {
			GUI.DrawTexture (new Rect (450, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);
		}
		if (caughtLetters>=7) {
			GUI.DrawTexture (new Rect (500, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);
		}
		if (caughtLetters>=8) {
			GUI.DrawTexture (new Rect (550, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);
		}
		if (caughtLetters>=9) {
			GUI.DrawTexture (new Rect (600, 20, 40, 40), aTexture1, ScaleMode.ScaleToFit, true, 1.0F);
			caughtLetters=0;
			SceneManager.LoadScene("Win1",LoadSceneMode.Single);
		

		}

	}
}