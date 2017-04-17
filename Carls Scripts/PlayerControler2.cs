using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour {

	//Obiekt odpowiedzialny za ruch gracza.
	public CharacterController characterControler;

	//Prędkość poruszania się gracza.
	public float predkoscPoruszania = 9.0f;
	//Wysokość skoku.
	public float wysokoscSkoku = 7.0f;
	//Aktualna wysokosc skoku.
	public float aktualnaWysokoscSkoku = 0f;
	//Predkosc biegania.
	public float predkoscBiegania = 7.0f;

	//Czulość myszki (Sensitivity)
	public float czuloscMyszki = 3.0f;  
	public float myszGoraDol = 0.0f;
	//Zakres patrzenia w górę i dół.
	public float zakresMyszyGoraDol = 90.0f;
	public int caughtLetters= 0;

	public static int Count=0;
	public Texture aTexture0;
	public Texture aTexture1;

	public AudioClip mySound;
	public AudioSource mySource;
	//bool dispLet1;

	//set variables for levels, Carl
	public string currentLevel;
	public int worldIndex;
	public int levelIndex

	void Start () {
		currentLevel = Application.loadedLevelName;//Saves the current level name, Carl
		characterControler = GetComponent<CharacterController>();
	}


	// Update is called once per frame
	void Update() {
		klawiatura();
		myszka();
	}

	//Metoda odpowiedzialna za poruszanie się na klawiaturze.
     
	private void klawiatura(){
		//Pobranie prędkości poruszania się przód/tył.
		// jeżeli wartość dodatnia to poruszamy się do przodu,
		// jeżeli wartość ujemna to poruszamy się do tyłu.
		float rochPrzodTyl = Input.GetAxis("Vertical") * predkoscPoruszania;
		//Pobranie prędkości poruszania się lewo/prawo.
		// jeżeli wartość dodatnia to poruszamy się w prawo,
		// jeżeli wartość ujemna to poruszamy się w lewo.
		float rochLewoPrawo = Input.GetAxis("Horizontal") * predkoscPoruszania;
		//Debug.Log (rochLewoPrawo);

		//Skakanie
		// Jeżeli znajdujemy się na ziemi i została naciśnięta spacja (skok)
		if(characterControler.isGrounded && Input.GetButton("Jump")){
			aktualnaWysokoscSkoku = wysokoscSkoku;
		} else if (!characterControler.isGrounded ){//Jezeli jestesmy w powietrzu(skok)
			//Fizyka odpowiadająca za grawitacje (os Y).
			aktualnaWysokoscSkoku += Physics.gravity.y * Time.deltaTime;
		}

		Debug.Log (Physics.gravity.y);

		//Bieganie
		if(Input.GetKeyDown("left shift")) {
			predkoscPoruszania+=predkoscBiegania;
		} else if(Input.GetKeyUp("left shift")) {
			predkoscPoruszania-=predkoscBiegania;
		}

		//Tworzymy wektor odpowiedzialny za ruch.
		//rochLewoPrawo - odpowiada za ruch lewo/prawo,
		//aktualnaWysokoscSkoku - odpowiada za ruch góra/dół,
		//rochPrzodTyl - odpowiada za ruch przód/tył.
		Vector3 ruch = new Vector3(rochLewoPrawo, aktualnaWysokoscSkoku, rochPrzodTyl);
		//Aktualny obrót gracza razy kierunek w którym sie poruszamy (poprawka na obrót myszką abyśmy szli w kierunku w którym patrzymy).
		ruch = transform.rotation * ruch;

		characterControler.Move(ruch * Time.deltaTime);
	}


      //Metoda odpowiedzialna za ruch myszką.
     
	private void myszka(){
		//Pobranie wartości ruchu myszki lewo/prawo.
		// jeżeli wartość dodatnia to poruszamy w prawo,
		// jeżeli wartość ujemna to poruszamy w lewo.
		float myszLewoPrawo = Input.GetAxis("Mouse X") * czuloscMyszki; 
		transform.Rotate(0, myszLewoPrawo, 0);

		//Pobranie wartości ruchu myszki góra/dół.
		// jeżeli wartość dodatnia to poruszamy w górę,
		// jeżeli wartość ujemna to poruszamy w dół.
		//myszGoraDol -= Input.GetAxis("Mouse Y") * czuloscMyszki;

		//Funkcja nie pozwala aby wartość przekroczyła dane zakresy.
		myszGoraDol = Mathf.Clamp(myszGoraDol, -zakresMyszyGoraDol, zakresMyszyGoraDol);
		//Ponieważ CharacterController nie obraca się góra/dół obracamy tylko kamerę.
		Camera.main.transform.localRotation = Quaternion.Euler(myszGoraDol, 0, 0);
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Letter") 
		{
			Destroy (other.gameObject);
			caughtLetters += 1;
			mySource.clip = mySound;
			mySource.Play();

			//dispLet1 = true;
		}
	}


	void OnGUI()
	{
		GUI.contentColor = Color.black;
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
			UnlockLevels ();//Unlocks next level, Carl
			SceneManager.LoadLevel("World1",LoadSceneMode.Single);//Loads the continue scene with the next level unlocked, Carl
		}
	}

	protected void UmlockLevels(){
		//set the player preferences value of the next level to 1 to unlock, Carl
		for (int i = 0; i < LockLevel.worlds; i++) {//checks the world level, only 1 world used in this game for now, Carl
			for(int j =1; j<LockLevel.levels; j++) {//checks the level the player is at, Carl
				if(currentLevel = "Level"+worldIndex.ToString() +"." +jvalue.ToString()){
					worldIndex = (i+1);//sets the player world to World1, Carl
					levelIndex = (j+1);//sets the player level to whatever level they have completed and increases it by 1 level, Carl
					PlayerPrefs.SetInt("Level"+worldIndex.ToString() + ":" + levelIndex.ToString(),1);//saves the level to the player preferences
				}
			}
		}
				//load the world1 level X, Carl
				SceneManager.LoadLevel("World1");
	}
}