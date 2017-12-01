using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {
	public Text countText;
    public Text levelText;
    public GameObject levTextObj;
	public static int count = 0;
    public int textShowTime;
    public int timer;
    public int timer2;

    void Start(){
        textShowTime = 100;
        timer = 0;
        timer2 = 0;
    }

    void Update(){
        SetCountText();
	}

	void SetCountText(){
		// Update the text field of our 'countText' variable
		countText.text = "Count: " + count.ToString ();

		if (count >= 10 & count <25) {
            enemy.level = 120;
            timer++;
            if (timer <= textShowTime) {
                levTextObj.SetActive(true);
            } else {
                levTextObj.SetActive(false);
            }
            levelText.text = "Level 2";
		} else if (count >= 25) {
            timer2++;
            if (timer2 <= textShowTime) {
                levTextObj.SetActive(true);
            } else {
                levTextObj.SetActive(false);
            }
			enemy.level = 70;
            levelText.text = "Level 3";
		}
	}
}	
