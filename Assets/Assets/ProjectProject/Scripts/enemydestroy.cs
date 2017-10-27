using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemydestroy : MonoBehaviour {
	public int heal;
	// Use this for initialization
	void Start () {
		heal=20;
	}
	
	// Update is called once per frame
	void Update () {
		
    }
    void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) heal--;
		if (heal == 0) Destroy (gameObject);
		else if (heal <= 8) GetComponent<Renderer>().material.color = Color.red;
		else if (heal <= 14) GetComponent<Renderer>().material.color = Color.yellow;
 	}
}
