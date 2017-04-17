using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Button ButtonCreateProfile;
	public Button ButtonStartNewGame;
	public Button ButtonContinueGame;
	public Button ButtonHowToPlay;
	public Button ButtonEXIT;
	public int SceneToLoad;

	private Canvas menuUI;
	// Use this for initialization
	void Start () {
		
		menuUI = GetComponent<Canvas>();

		ButtonCreateProfile = ButtonCreateProfile.GetComponent<Button> ();
		ButtonStartNewGame = ButtonStartNewGame.GetComponent<Button> ();
		ButtonContinueGame = ButtonContinueGame.GetComponent<Button> ();
		ButtonHowToPlay = ButtonHowToPlay.GetComponent<Button> ();
		ButtonEXIT = ButtonEXIT.GetComponent<Button> ();
		//Time.timeScale = 0;

		Cursor.visible = menuUI.enabled;//Ukrycie pokazanie kursora myszy. Hide the mouse cursor
		Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy. Unlock the mouse cursor.
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) { //Jeżeli naciśnięto klawisz "Escape", If you pressed "Escape"
			menuUI.enabled = !menuUI.enabled;//Ukrycie/pokazanie menu. Hide / show menu.

			Cursor.visible = menuUI.enabled;//Ukrycie pokazanie kursora myszy. Hide the mouse cursor.

			if(menuUI.enabled) {
				Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy. Unlock the mouse cursor.
				Cursor.visible = true;//Pokazanie kursora.
				//Time.timeScale = 0;//Zatrzymanie czasu.
				ButtonCreateProfile.enabled = true; //Aktywacja przycsiku 'Create Profile'. Activation of the 'Create Profile'
				ButtonStartNewGame.enabled = true;
				ButtonContinueGame.enabled = true;
				ButtonHowToPlay.enabled = true;
				ButtonEXIT.enabled = true;

			} 
			else {  Cursor.lockState = CursorLockMode.Locked; //Zablokowanie kursora myszy. Lock the mouse cursor.
				Cursor.visible = false;//Ukrycie kursora. Hide cursor.
				Time.timeScale = 1;//Włączenie czasu. Turn on time.
			}
	}
}
	public void NewGame (){
		SceneManager.LoadScene("StartNewGame");
		menuUI.enabled = false; //Ukrycie głównego menu. Hide the main menu.
	}
	public void CrePro (){
		SceneManager.LoadScene("CreateProfile"); 
		menuUI.enabled = false; //Ukrycie głównego menu.
	}
	public void ConGame (){
		SceneManager.LoadScene("ContinueGame");  
		menuUI.enabled = false; //Ukrycie głównego menu.
	}
	public void HowTo (){
		SceneManager.LoadScene("HowToPlay"); //this will load our first level from our build settings. "1" is the second scene in our game  
		menuUI.enabled = false; //Ukrycie głównego menu.
	}
	public void exitGame () {
		Application.Quit(); //Powoduje wyjście z gry.
}
}