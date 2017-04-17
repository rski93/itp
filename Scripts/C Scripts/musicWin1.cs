using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicWin1 : MonoBehaviour {

	public GameObject musicPlayer;
	void Awake() {
		//When the scene loads it checks if there is an object called "MUSIC".
		musicPlayer = GameObject.Find("All Fall Down.mp3");
		if(musicPlayer==null)
		{
			//If this object does not exist then it does the following:
			//1. Sets the object this script is attached to as the music player
			musicPlayer = this.gameObject;
			//2. Renames THIS object to "MUSIC" for next time
			musicPlayer.name = "All Fall Down.mp3";
			//3. Tells THIS object not to die when changing scenes.
			DontDestroyOnLoad(musicPlayer);
		}
		else{
			if(this.gameObject.name!="All Fall Down.mp3"){
				//If there WAS an object in the scene called "MUSIC" (because we have come back to
				//the scene where the music was started) then it just tells this object to 
				//destroy itself if this is not the original
				Destroy(this.gameObject);
			}
		}
	}
	void Update(){
		if (Application.loadedLevelName == "Win1") {
			Destroy (this.gameObject);
		}
	}
}