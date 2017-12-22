using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser2 : MonoBehaviour
{
    public GameObject Game;
    public GameObject laser;
    public static int rotateSpeed;
    public float b;
    public int x;
    public int timerx;


    // Use this for initialization
    void Start(){

       x = 0;

    }

    // Update is called once per frame
    void FixedUpdate() {
        if (ScoreSystem.shouldSpawnLaser2[ScoreSystem.i-1] == 1) {
            if (rotateSpeed <= 360) {
                laser.transform.rotation = Quaternion.Euler(0, rotateSpeed, 0);
                rotateSpeed += 3;
            } else if (rotateSpeed >= 360) {
                rotateSpeed = 0;
                laser.transform.rotation = Quaternion.Euler(0, rotateSpeed, 0);
            }
            if (x == 587) {
                Destroy(GameObject.FindWithTag("wow"));
            }
            if (x >= 600) {
                var lobj = Instantiate(Game, new Vector3(Random.Range(-6f, 6f), 0.5f, Random.Range(-6f, 6f)), Game.transform.rotation);
                lobj.gameObject.tag = "wow";
                x = 0;
            } else {
                x += 1;
                timerx = x;
            }
        }
    }
}

