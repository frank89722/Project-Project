﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControll : MonoBehaviour {
	public float mSpeed;
	// Use this for initialization
	void Start () {
		mSpeed = 0.3f;
	}
	// Update is called once per frame
	void Update () {
		//transform.Translate (mSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);

		if (Input.GetKey (KeyCode.W) & Input.GetKey (KeyCode.D)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 45f, 0f);
			transform.position += Vector3.forward * mSpeed;
		} else if (Input.GetKey (KeyCode.S) & Input.GetKey (KeyCode.D)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 135f, 0f);
		} else if (Input.GetKey (KeyCode.A) & Input.GetKey (KeyCode.S)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 225f, 0f);
		} else if (Input.GetKey (KeyCode.A) & Input.GetKey (KeyCode.W)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 315f, 0f);
		} else if (Input.GetKey (KeyCode.W)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		} else if (Input.GetKey (KeyCode.A)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 270f, 0f);
		} else if (Input.GetKey (KeyCode.S)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 180f, 0f);
		} else if (Input.GetKey (KeyCode.D)) {
			transform.position += Vector3.forward * mSpeed;
			gameObject.transform.rotation = Quaternion.Euler (0f, 90f, 0f);
		}
	}
}
