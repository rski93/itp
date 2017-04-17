using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class PlayerController : MonoBehaviour {
	public float speed;
	public Text countText;
	public Text winText;

	//declare rb as variable for RigidForce
	private Rigidbody rb;
	private int count;


	//will activate it from the start
	void Start(){
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";

	}
	//controles the physics of the object
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
		rb.AddForce (movement * speed);
			
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Pick Up"));
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}
	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
		if(count >= 12){
			winText.text = "You Win!";
		}
	}
}
