using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
		
	public GameObject pauseButton, pausePanel, backButton, restartButton;
    public Text pausePanel_text;
    public static bool gOver;
    public static bool pauseType;

	void Start(){
		pausePanel.SetActive (false);
		pauseButton.SetActive (false);
		backButton.SetActive (false);
		StartCoroutine(PauseCoroutine());
        gOver = false;
	}
	public IEnumerator PauseCoroutine() {
		while (true){
			if (Input.GetKeyDown(KeyCode.Escape)){
                pauseType = true;
				if (Time.timeScale == 0){
					UnPause ();
				} else {
					OnPause ();
				}
			} else if(gOver == true) {
                pauseType = false;
                OnPause();
            }
			yield return null;
		}
	}

	public void OnPause(){
        SetText();
		Time.timeScale = 0;
        if (pauseType == true) {
            pauseButton.SetActive(true);
        }else {
            pauseButton.SetActive(false);
        }
        if (pauseType == true) {
            restartButton.SetActive(false);
        }
        else {
            restartButton.SetActive(true);
        }

        pausePanel.SetActive (true);
        backButton.SetActive(true);
	}  

	public void UnPause(){
		pausePanel.SetActive (false);
		pauseButton.SetActive (false);
		backButton.SetActive (false);
		Time.timeScale = 1;
	}

    void SetText() {
        if(pauseType == false) {
            pausePanel_text.text = "Game Over";
        } else {
            pausePanel_text.text = "Game Paused";
        }
    }
}
