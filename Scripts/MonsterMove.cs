using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour {

	private string state= "idle";
	private UnityEngine.AI.NavMeshAgent nav;


	private Vector3 targetAngles;

	// Use this for initialization
	void Start () {
		
		if (GetComponent<Rigidbody> ()) {
			GetComponent<Rigidbody> ().freezeRotation = true;
			//
		}
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		Physics.defaultContactOffset = 0.1F;
	}


	// Update is called once per frame
	void Update () {

		//if (alive) 
		{
			
			if (state == "idle")
			{
				//pick a random place to walk to//
				Vector3 randomPos = Random.insideUnitSphere*30f;
				UnityEngine.AI.NavMeshHit navHit;
				UnityEngine.AI.NavMesh.SamplePosition (transform.position + randomPos, out navHit, 30f, UnityEngine.AI.NavMesh.AllAreas);
				nav.SetDestination (navHit.position);
				state = "walk";
			}

			if (state == "walk") 
			{
				if (nav.remainingDistance <= nav.stoppingDistance && !nav.pathPending) 
				{
					state = "idle";
				}
			}
		}

	}
}