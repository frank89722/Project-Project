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
    private int timer;
    private int timer2;
    public GameObject bigmama;
    private int flag1;

    void Start(){
        timer = 0;
        timer2 = 0;
        flag1 = 0;
    }

    void Update(){
        SetLevel();
	}

	void SetLevel(){
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
			enemy.level = 90;
            levelText.text = "Level 3";
            if (flag1 < 2) {
                Ispawner.SpawnEnemy(bigmama);
                flag1++;
            }
		}
	}
}	
