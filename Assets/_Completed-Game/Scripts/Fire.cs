using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
 
    public float speed = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kire();
        }

    }
    void kire()
    {
        // Create the Bullet from the Bullet Prefab

        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.transform.Translate(0, 0, 70 * Time.deltaTime);

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
}



