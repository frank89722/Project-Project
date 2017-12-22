using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float mSpeed;

    void Start(){
        mSpeed = 0.38f;
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (CubeControll.laserStart == true) mSpeed = 0.45f;
        bulletPrefab.transform.Translate(Vector3.forward * mSpeed);
    }

    void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Wall") | other.gameObject.CompareTag ("enemy") | other.gameObject.CompareTag("enemy2")) {
			Destroy (gameObject);
		}
	}
}



