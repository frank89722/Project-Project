using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject box;
    public float x;
	public static int level;
    // Use this for initialization
    void Start(){
		level = 200;
        x = 199;
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (x >= level) {
            Ispawner.SpawnEnemy(box);
            x = 0;
        } else {
            x += 1;
        }
    }
}
     	

