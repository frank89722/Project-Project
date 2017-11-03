using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SCC{
public class ScoreSystem {
	public Text countText;
	public Text winText;
	public int count;
		 
	void Start(){
		SetCountText ();
		count = 0;
	}

	public void Counter(int countfor){
		//count = count+countfor;
		//SetCountText ();
	}

	void SetCountText()
	{
		// Update the text field of our 'countText' variable
		countText.text = "Count: " + count.ToString ();

		// Check if our 'count' is equal to or exceeded 12
		if (count >= 12) 
		{
			// Set the text value of our 'winText'
			winText.text = "You Win!";
		}
	}
}	
}
