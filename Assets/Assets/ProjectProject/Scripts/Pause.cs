using System.Collections;
using UnityEngine;

public class Pause : MonoBehaviour {
		
	public GameObject pasueButton, pausePanel;

	void Start()
	{
		pausePanel.SetActive (false);
		pasueButton.SetActive (false);
		StartCoroutine(PauseCoroutine());    
	}
	IEnumerator PauseCoroutine() {
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
	}  

	public void UnPause(){
		pausePanel.SetActive (false);
		pasueButton.SetActive (false);
		Time.timeScale = 1;
	}


}
