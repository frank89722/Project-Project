using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject box;
    public GameObject bigMama;
    public float x;
	public static int level;
    public static bool spawn;
    // Use this for initialization
    void Start(){
		level = 200;
        x = 198;
        spawn = false;
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (spawn == true) {
            if (ScoreSystem.shouldSpawnEnemyCube[ScoreSystem.i-1] == 1) {
                if (x >= level) {
                    Ispawner.SpawnEnemy(box);
                    x = 0;
                    ScoreSystem.spawnCounter++;
                }
                else {
                    x += 1;
                }
            }
            else if (ScoreSystem.shouldSpawnBigmama[ScoreSystem.i - 1] == 1) {
                if (x >= level) {
                    Ispawner.SpawnEnemy(bigMama);
                    x = 0;
                    ScoreSystem.spawnCounter++;
                }
                else {
                    x += 1;
                }
            }
        }
    }
}
     	

