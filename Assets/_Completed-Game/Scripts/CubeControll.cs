using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControll : MonoBehaviour {
	public float mSpeed;
	private Rigidbody rb;
	public GameObject bulletPrefab;
    public Transform bulletSpawn;
	// Use this for initialization
	void Start () {
		mSpeed = 0.2f;
		rb = GetComponent<Rigidbody>();
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		
		//transform.Translate (mSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
    
		// Set some local float variables equal to the value of our Horizontal and Vertical Inputs
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// Add a physical force to our Player rigidbody using our 'movement' Vector3 above, 
		// multiplying it by 'speed' - our public player speed that appears in the inspectors
		rb.AddForce (movement * mSpeed);
		if (Input.GetKey (KeyCode.W) & Input.GetKey (KeyCode.D)) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 45f, 0f);
            transform.Translate(new Vector3(0, 0, 1)*mSpeed);
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
		
			fire();
		
		   
   	}
	   void fire()
	   {
		   if(Input.GetKey(KeyCode.Space)){
		    var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
          //  bullet.transform.Translate(Vector3.forward * 3f *1 );
        // Add velocity to the bullet
       
        // Destroy the bullet after 2 seconds
        Destroy(bullet, 0.5f);
		   }
	   }
}
