﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotFire : MonoBehaviour
{
	public GameObject bulletPrefab;
	private float mSpeed;
	public string targett;

	void Start(){
		mSpeed = 0.1f;
	}

	void Update(){
		bulletPrefab.transform.Translate(Vector3.forward * mSpeed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Wall") | other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
		}
	}
}


