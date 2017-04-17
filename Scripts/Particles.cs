using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {

	public Transform CaLePart;
	// Use this for initialization
	void Start () {
		CaLePart.GetComponent<ParticleSystem>().enableEmission=false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
