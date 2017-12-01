using System.Collections;
using UnityEngine;

public class Pause : MonoBehaviour {
		
	public GameObject pasueButton, pausePanel, backButton;

	void Start()
	{
		pausePanel.SetActive (false);
		pasueButton.SetActive (false);
		backButton.SetActive (false);
		StartCoroutine(PauseCoroutine());    
	}
	public IEnumerator PauseCoroutine() {
		while (true)
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				if (Time.timeScale == 0){
					UnPause ();
				} else {
					OnPause ();
				}
			}    
			yield return null;
		}
	}

	public void OnPause(){
		Time.timeScale = 0;
		pasueButton.SetActive (true);
		pausePanel.SetActive (true);
		backButton.SetActive (true);
	}  

	public void UnPause(){
		pausePanel.SetActive (false);
		pasueButton.SetActive (false);
		backButton.SetActive (false);
		Time.timeScale = 1;
	}


}
