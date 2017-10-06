using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
       public GameObject box;
	   public float x;
	// Use this for initialization
	void Start () {
		x = 0;
	}
	
	// Update is called once per frame
	void Update () {
	     if(x==100)
		 {
			 Instantiate(box, new Vector3(Random.Range(-8f,8f),0.5f,Random.Range(-8f,8f)), box.transform.rotation);
			 x=0;
		 }	
		 else
		 {
            x+=1;
		 }
	}	
}
