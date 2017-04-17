using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class CreateProfile : MonoBehaviour {
	public InputField usernameInput;
	//public static string PlayerName;

	public int ProfileId;
	public string PlayerName;
	public int LevelProgress;
	//public bool alreadyName;

	void Start() {
		
		if(PlayerName != null)
			usernameInput.text = PlayerName;
	}
	/*
	public void SaveUsername(string newName) {
		PlayerName = newName;
	}
	*/
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfo.dat");


		//Variable
		PlayerData data = new PlayerData ();
		data.PlayerName = PlayerName;

		bf.Serialize (file, data);
		file.Close ();
	}

	[Serializable]
	class PlayerData
	{
		//public int ProfileId;
		public string PlayerName;
		//public int LevelProgress;
	}
}
