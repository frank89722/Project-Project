using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float mSpeed;
    //public GameObject bullet;
    // Use this for initialization
    void Start(){
        mSpeed = 0.3f;
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        

    //var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
     bulletPrefab.transform.Translate(Vector3.forward * mSpeed);
    
        
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



