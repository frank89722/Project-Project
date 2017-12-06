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
    public static int i = 1;
    private int[] scores = new int[] { 10, 25, 29, 45 };
    private int[] spawnSpeed = new int[] { 180, 120, 1, 80 };
    public static int[] shouldSpawnBigmama = new int[] { 0, 0, 1, 0 };
    public static int spawnCounter = 0;
    public GameObject bigmama;
    public GameObject EnemyOntology;


    void Start(){
        timer = 0;
    }

    void Update(){
        SetLevel();
	}

	void SetLevel(){
		// Update the text field of our 'countText' variable
		countText.text = "Count: " + count.ToString ();

        //i=level
        if (i < 5 && i > 3) {
            if (count <= scores[i - 1]) {
                if (spawnCounter <= scores[i - 1]) {
                    enemy.spawn = true;
                    enemy.level = spawnSpeed[i - 1];
                    IlevelText();
                    levelText.text = "Level" + i;
                }
                else {
                    enemy.spawn = false;
                    timer = 0;
                    i++;
                }
            }
        }
        else if (count <= scores[i - 1]) {
            if (spawnCounter <= scores[i - 1]) {
                enemy.spawn = true;
                enemy.level = spawnSpeed[i - 1];
                IlevelText();
                levelText.text = "Level" + i;
            }
            else {
                enemy.spawn = false;
                timer = 0;
                i++;
            }
        }
            /*if(count <= 10) {
                if(spawnCounter <= 10) {
                    enemy.spawn = true;
                    enemy.level = 120;
                    IlevelText();
                    levelText.text = "Level 1";
                }
                else {
                    enemy.spawn = false;
                    timer = 0;
                }
            }*/

            /*if (count >= 2 & count <4) {
                enemy.level = 120;
                timer++;
                if (timer <= textShowTime) {
                    levTextObj.SetActive(true);
                } else {
                    levTextObj.SetActive(false);
                }
                levelText.text = "Level 2";
            } else if (count >= 5) {
                timer2++;
                if (timer2 <= textShowTime) {
                    levTextObj.SetActive(true);
                } else {
                    levTextObj.SetActive(false);
                }
                enemy.level = 90;
                levelText.text = "Level 3";
                if (flag1 / 4 ==0) {
                    Ispawner.SpawnEnemy(bigmama);
                    flag1++;
                }
            }*/
        }
    void IlevelText() {
        timer++;
        if (timer <= textShowTime) {
            levTextObj.SetActive(true);
        }
        else {
            levTextObj.SetActive(false);
        }
    }
}	
