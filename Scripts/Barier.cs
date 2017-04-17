/*
 * Barier.cs
 * @author Dariusz Hanuszewicz
 * 07.04.2017
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barier : MonoBehaviour {
	//http://answers.unity3d.com/questions/946210/random-spawn-position.html
	public GameObject enemy;                // The enemy prefab to be spawned.
	public float spawnTime = 1f;            // How long between each spawn.
	// Use this for initialization
	void Start () {
		{

	//**************** @author Dariusz Hanuszewicz ***********************
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Letter") 
		{
			Destroy (other.gameObject);
			Spawn ();
		}
			
	}
	//http://answers.unity3d.com/questions/946210/random-spawn-position.html
	void Spawn ()
	{    
		int spawnPointX = Random.Range (-120, -365);
		int spawnPointZ = Random.Range (150, 350);

	//**************** @author Dariusz Hanuszewicz change *****************
		Vector3 spawnPosition = new Vector3 (spawnPointX,21, spawnPointZ);
		//http://answers.unity3d.com/questions/946210/random-spawn-position.html
		Instantiate(enemy, spawnPosition, Quaternion.identity);
	}
}
