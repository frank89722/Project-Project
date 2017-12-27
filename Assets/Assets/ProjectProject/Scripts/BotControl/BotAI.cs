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
    public AudioSource Cube1_audio;
    //public AudioSource Cube2_audio;
    private int delayCounter = 0;
    public int delay;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
    public bool move;

	// Use this for initialization
	void Start (){
		Leader = GameObject.FindGameObjectWithTag("Player").transform;
	}
		
	void FixedUpdate (){
		transform.LookAt(Leader);
		AI();
		fire ();
	}

	void AI(){
        if (move == true) {
            if (Vector3.Distance(transform.position, Leader.position) >= MinDistance & Vector3.Distance(transform.position, Leader.position) <= MaxDistance) {
                transform.position += transform.forward * AISpeed * Time.deltaTime;
            }
        } else {
            if (Vector3.Distance(transform.position, Leader.position) >= MinDistance & Vector3.Distance(transform.position, Leader.position) <= MaxDistance) {
                transform.position += transform.forward * 0f * Time.deltaTime;
            }
        }
	}

	void fire(){		
		delayCounter++;
        if (delayCounter >= delay) {
            var bullets = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            Destroy(bullets, 10f);
            Cube1_audio.Play();                                                                                                                       
            delayCounter = 0;
        }
	}
}