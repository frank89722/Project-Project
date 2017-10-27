using System.Collections;
using UnityEngine;

public class LevelManger : MonoBehaviour {

	public void LoadGame(string name){
		Application.LoadLevel (name);
	}
}
