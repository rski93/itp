using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;
	public float profile;
	public float levels;

	void Awake () {

		if (control == null) {
				DontDestroyOnLoad (gameObject);
				control = this;
			} 
			else if (control != this) {
				Destroy (gameObject);
			}
		Save ();
		Load ();
		Score ();
	}

	/*
	void OnGUI()
	{
		GUI.contentColor = Color.black;
		GUI.Label (new Rect (400, 100, 200, 50), "Available levels: "+ levels.ToString ());	
	}
	*/

	//saving progress
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfo.dat");


	//Variable
		PlayerData data = new PlayerData ();
		data.profile = profile;
		data.levels = levels;

		bf.Serialize (file, data);
		file.Close ();
	}


	//loading progress
	public void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();

	//variable
			profile = data.profile;
			levels=data.levels;
		}
	}


	//Variable
	[Serializable]
	class PlayerData
	{
		public float profile;
		public float levels;
	}

	public void Score()
	{
		if (PlayerControler.caughtLetters >= 1)
			Debug.Log("******************************");
	}
	class GameProfile
	{
		int ProfileId;
		string PlayerName;
		int LevelProgress;
	}
}
