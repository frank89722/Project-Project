﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float mSpeed;
	public string targett;

    void Start(){
        mSpeed = 0.4f;
    }

    // Update is called once per frame
    void Update(){
         bulletPrefab.transform.Translate(Vector3.forward * mSpeed);
    }

    void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Wall")) {
			Destroy (gameObject);
		}
	}
}



