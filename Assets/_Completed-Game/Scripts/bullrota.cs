using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullrota : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.GetKey (KeyCode.W) & Input.GetKey (KeyCode.D) & Input.GetKey (KeyCode.Space)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 45f, 0f);
        } else if (Input.GetKey (KeyCode.S) & Input.GetKey (KeyCode.D)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 135f, 0f);
            transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        } else if (Input.GetKey (KeyCode.A) & Input.GetKey (KeyCode.S)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 225f, 0f);
            transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        } else if (Input.GetKey (KeyCode.A) & Input.GetKey (KeyCode.W)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 315f, 0f);
			transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        } else if (Input.GetKey (KeyCode.W)) {
			transform.position += Vector3.forward * mSpeed;
			gameObject.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		} else if (Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.left * mSpeed;
			gameObject.transform.rotation = Quaternion.Euler (0f, 270f, 0f);
		} else if (Input.GetKey (KeyCode.S)) {
			transform.position += Vector3.back * mSpeed;
			gameObject.transform.rotation = Quaternion.Euler (0f, 180f, 0f);
		} else if (Input.GetKey (KeyCode.D)) {
			transform.position += Vector3.right * mSpeed;
			gameObject.transform.rotation = Quaternion.Euler (0f, 90f, 0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
