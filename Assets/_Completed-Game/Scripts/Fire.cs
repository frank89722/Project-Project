using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Rigidbody rb;
    public float mSpeed;
    //public GameObject bullet;
    // Use this for initialization
    void Start(){
        mSpeed = 0.5f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        

    //var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
     bulletPrefab.transform.Translate(Vector3.forward * mSpeed);
        
    }

    void OnTriggerEnter(Collider other) 
    {
		// ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("Wall"))
		{
			// Make the other game object (the pick up) inactive, to make it disappear
			gameObject.SetActive (false);
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



