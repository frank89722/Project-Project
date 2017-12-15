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
    public static int i = 1;
    private int overtimeCount = 150;
    private int otc = 0;
    private int[] scores = new int[] { 10, 20, 24, 40,60 };
    private int[] spawnSpeed = new int[] { 180, 120, 1, 80, 90 };
    public static byte[] shouldSpawnEnemyCube = new byte[] { 1, 1, 0, 1, 1 };
    public static byte[] shouldSpawnBigmama = new byte[] { 0, 0, 1, 0,0 };
    public static byte[] shouldSpawnLaser2 = new byte[]{0,0,0,0,1};
    public static int spawnCounter;
    public GameObject bigmama;


    void Start(){
        timer = 0;
        count = 0;
        spawnCounter = 0;

    }

    void Update(){
        SetLevel();
	}

	void SetLevel(){
		countText.text = "Count: " + count.ToString ();
        int xyz = scores.Length;

        //i=level
        //This is level control
        if (i <= xyz) {
            if (count <= scores[i - 1]) {
                if (spawnCounter < scores[i - 1]) {
                    CannonHeal.multipleDamage = 1.2f;
                    enemy.spawn = true;
                    enemy.level = spawnSpeed[i - 1];
                    IlevelText();
                    levelText.text = "Level" + i;
                } 
                if (count == scores[i - 1]) {
                    enemy.spawn = true;
                    timer = 0;
                    i++;
                }
                if (spawnCounter == scores[i - 1]) {
                    enemy.spawn = false;
                    IlevelText();
                }
            }
        //Infinity mode
        }else if(i > xyz){
            CannonHeal.multipleDamage = 2.5f;
            if(otc >= overtimeCount){
                Ispawner.SpawnEnemy(bigmama);
                otc = 0;
            } else {
                otc++;
            }
            
        }
    }
    void IlevelText() {
        if (timer < textShowTime) {
            levTextObj.SetActive(true);
            timer++;
        }
        else {
            levTextObj.SetActive(false);
        }
    }
}	
