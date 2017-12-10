using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_laser : MonoBehaviour {
    public GameObject bulletPrefab;
    public float mSpeed;

    void Start() {
        mSpeed = 1f;
    }

    // Update is called once per frame
    void FixedUpdate() {
        bulletPrefab.transform.Translate(Vector3.forward * mSpeed);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Wall") | other.gameObject.CompareTag("enemy") | other.gameObject.CompareTag("enemy2")) {
            Destroy(gameObject);
        }
    }
}



