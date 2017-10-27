using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Rigidbody rb;
    public GameObject emy;
    public float mSpeed;
    //public GameObject bullet;
    // Use this for initialization
    void Start(){
        mSpeed = 0.6f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        

    //var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
     bulletPrefab.transform.Translate(Vector3.forward * mSpeed);
    }

    void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Wall")){
            Destroy(gameObject);
		}
	}
       
   /* void kire()
    {
        // Create the Bullet from the Bullet Prefab

        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // Add velocity to the bullet
       
        // Destroy the bullet after 2 seconds
        Destroy(bullet, 1.0f);
    }*/
}



