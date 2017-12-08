﻿using System.Collections;
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
    private int overtimeCount = 100;
    private int otc = 0;
    private int[] scores = new int[] { 10, 20, 24, 40 };
    private int[] spawnSpeed = new int[] { 180, 120, 1, 80 };
    public static int[] shouldSpawnBigmama = new int[] { 0, 0, 1, 0 };
    public static int spawnCounter = 0;
    public GameObject bigmama;


    void Start(){
        timer = 0;
    }

    void Update(){
        SetLevel();
	}

	void SetLevel(){
		countText.text = "Count: " + count.ToString ();
        int xyz = scores.Length;

        //i=level
        if (i <= xyz) {
            if (count <= scores[i - 1]) {
                if (spawnCounter < scores[i - 1]) {
                    enemy.spawn = true;
                    enemy.level = spawnSpeed[i - 1];
                    IlevelText();
                    levelText.text = "Level" + i;
                } else if (count == scores[i - 1]) {
                    enemy.spawn = true;
                    timer = 0;
                    i++;
                } else if (spawnCounter == scores[i - 1]) {
                    enemy.spawn = false;
                }
            }
        }else if(i > xyz){
            if(otc >= overtimeCount){
                Ispawner.SpawnEnemy(bigmama);
                otc = 0;
            } else {
                otc++;
            }
            
        }
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
