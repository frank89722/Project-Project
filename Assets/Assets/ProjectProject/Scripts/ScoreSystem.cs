using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {
	public Text countText;
	public Text winText;
	public static int count = 0;
		 
	void Update(){
		SetCountText();
	}


	public void Counter(int countfor){
	}

	void SetCountText()
	{
		// Update the text field of our 'countText' variable
		countText.text = "Count: " + count.ToString ();

		// Check if our 'count' is equal to or exceeded 12
		if (count >= 10) {
			enemy.level = 120;
		} else if (count >= 25) {
			enemy.level = 70;
		}
	}
}	
