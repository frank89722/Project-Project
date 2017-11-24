using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BotAI : MonoBehaviour
{
	// Variables for FollowBot
	Transform Leader;
	public float AISpeed = 0.8f;
	public float MaxDistance = 10f;
	public float MinDistance = 0.01f;
	public int delay;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	// Use this for initialization
	void Start (){
		Leader = GameObject.FindGameObjectWithTag("Player").transform;
		delay = 0;
	}
		
	void FixedUpdate (){
		transform.LookAt(Leader);
		AI();
		fire ();
	}

	void AI(){
		if (Vector3.Distance (transform.position, Leader.position) >= MinDistance & Vector3.Distance (transform.position, Leader.position) <= MaxDistance){
			transform.position += transform.forward*AISpeed*Time.deltaTime;
		}
	}

	void fire(){		
		delay++;
		if (delay >= 40) {
			var bullets = (GameObject)Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
			Destroy (bullets, 10f);
			delay = 0;
		}
	}
}
