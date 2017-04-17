using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class damagePlayer : MonoBehaviour {
	public GameObject Player;
	//public int cubeHealth = 30;
	//int damage=10;
	// Use this for initialization
	void Start () {
		//print (cubeHealth);
	}
	
	/*void OnCollisionEnter(Collision _collision)
	{
		if (_collision.gameObject.tag == "Cube") 
		{
			Destroy(this.gameObject);
			//cubeHealth -= damage;
			//print ("Contact"+ cubeHealth);
		}
	}
*/
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			PlayerControler.Count =+1;
			Destroy (this.gameObject);
		}
	}
}
