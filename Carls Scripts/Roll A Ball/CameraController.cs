using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {//sets the position of the camera in relation to the player x, y, z coordinates, Carl
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {//updates the position of the camera every frame to 'follow' the player, Carl
		transform.position = player.transform.position + offset;
	}
}
