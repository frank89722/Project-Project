using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser2 : MonoBehaviour
{
    public GameObject Game;
    public GameObject laser;
    public AudioSource laser2_audio;
    public bool laser2_audio_flag;
    public static int rotateSpeed;
    public float b;
    public int x;
    public int timerx;


    // Use this for initialization
    void Start(){
        x = 0;
        laser2_audio_flag = false;
    }

    // Update is called once per frame
    void FixedUpdate() {
        /*if(laser2_audio_flag == true){
            laser2_audio.Play();
        } else {
            laser2_audio.Stop();
        }*/

        if (ScoreSystem.shouldSpawnLaser2[ScoreSystem.i-1] == 1) {
            if (rotateSpeed <= 360) {
                laser.transform.rotation = Quaternion.Euler(0, rotateSpeed, 0);
                rotateSpeed += 4;
            } else if (rotateSpeed >= 360) {
                rotateSpeed = 0;
                laser.transform.rotation = Quaternion.Euler(0, rotateSpeed, 0);
            }
            if (x == 350) {
                Destroy(GameObject.FindWithTag("wow"));
                laser2_audio.Stop();
            }
            if (x >= 420) {
                var lobj = Instantiate(Game, new Vector3(Random.Range(-6f, 6f), 0.5f, Random.Range(-6f, 6f)), Game.transform.rotation);
                lobj.gameObject.tag = "wow";
                laser2_audio.Play();
                x = 0;
            } else {
                x += 1;
                timerx = x;
            }
        }
    }
}

