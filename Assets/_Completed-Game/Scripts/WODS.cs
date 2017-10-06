using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WODS : MonoBehaviour {
    public GameObject bulletPrefab;
	void Start () {
		
	}

	void OnTriggerEnter(Collider other) 
	{
		// ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("Wall"))
		{
			// Make the other game object (the pick up) inactive, to make it disappear
			Destroy(bulletPrefab);

			// Add one to the score variable 'count'
			//count = count + 1;

			// Run the 'SetCountText()' function (see below)
			//SetCountText ();
		}
	}
}
