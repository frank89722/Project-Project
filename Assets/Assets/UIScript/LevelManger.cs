using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour {


	public void Loadff(int tass){
		SceneManager.LoadScene (tass);
        Time.timeScale = 1;
        bloodpackage.x = 0;
        ScoreSystem.count = 0;

	}

}
