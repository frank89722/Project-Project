using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour {
	public GameObject MeanuPenal;
	public GameObject HTPP;
	public GameObject HTPB;
	public GameObject PB;
	public GameObject QuitB;
	public GameObject ExitB;
	// Use this for initialization
	void Start () {
		MeanuPenal.SetActive (true);
		HTPP.SetActive (false);
		PB.SetActive (true);
		HTPB.SetActive (true);
		ExitB.SetActive (true);
		QuitB.SetActive (false);
	}
	
	// Update is called once per frame
	public void ButtonHowtoPlayclicked(){
		MeanuPenal.SetActive (true);
		HTPP.SetActive (true);
		PB.SetActive (false);
		HTPB.SetActive (false);
		ExitB.SetActive (false);
		QuitB.SetActive (true);
	}
	public void ButtonEclicked(){
		MeanuPenal.SetActive (true);
		HTPP.SetActive (false);
		PB.SetActive (true);
		HTPB.SetActive (true);
		ExitB.SetActive (true);
		QuitB.SetActive (false);
	}

	void Update(){
		if (Input.GetKey (KeyCode.A)) {
			ButtonEclicked ();
		}
	}
}
