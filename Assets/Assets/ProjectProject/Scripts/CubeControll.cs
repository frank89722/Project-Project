using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControll : MonoBehaviour
{
    public float mSpeed;
    public Rigidbody rb;
    public GameObject player;
    public GameObject bulletPrefab;
    public GameObject laserPrefab;
    public GameObject Gun;
    public GameObject laserGun;
    public AudioSource bullet_one;
    public AudioSource bullet_two;
    public AudioSource player_laser_start;
    public Transform bulletSpawn;
    public Transform laserSpawn;
    private short audio_laser_delay=0;
    public int delay;

    private bool laserFlag;
    public static bool laserStart;
    // Use this for initialization
    void Start(){
        mSpeed = 0.2f;
        rb = GetComponent<Rigidbody>();
        delay = 0;
        laserFlag = false;
        laserStart = false;
    }
    // Update is called once per frame
    void FixedUpdate(){
        if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.D) & Time.timeScale != 0){
            player.transform.rotation = Quaternion.Euler(0f, 45f, 0f);
            player.transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        }
        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.D)){
            player.transform.rotation = Quaternion.Euler(0f, 135f, 0f);
            player.transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        }
        else if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.S)){
            player.transform.rotation = Quaternion.Euler(0f, 225f, 0f);
            player.transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        }
        else if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.W)){
            player.transform.rotation = Quaternion.Euler(0f, 315f, 0f);
            player.transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        }
        else if (Input.GetKey(KeyCode.W)){
            player.transform.position += Vector3.forward * mSpeed;
            player.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A)) {
            player.transform.position += Vector3.left * mSpeed;
            player.transform.rotation = Quaternion.Euler(0f, 270f, 0f);
        }
        else if (Input.GetKey(KeyCode.S)){
            player.transform.position += Vector3.back * mSpeed;
            player.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetKey(KeyCode.D)){
            player.transform.position += Vector3.right * mSpeed;
            player.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
    
        fire();
        laser();
    }

    void fire(){
        if (Input.GetKey(KeyCode.Space)){
            delay++;
            if (delay == 3){
                var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
                Destroy(bullet, 3f);
                delay = 0;
                bullet_one.Play();
            }
        }
    }

    void laser(){
        if (Input.GetKey(KeyCode.L)) {
            laserStart = true;
        }
        if (laserStart == true) {
            if (ScoreSystem.laserGo == true) {
                if (laserFlag == false) {
                    player_laser_start.Play();
                    laserFlag = true;
                    ScoreSystem.laserTimer = 500;
                    laserStartAnime.gun1(Gun);
                    laserStartAnime.gun2(laserGun);
                }
                else if (laserFlag == true) {
                    leadheal.cur_heal = leadheal.max_heal;
                    var bulletL = (GameObject)Instantiate(laserPrefab, laserSpawn.position, laserSpawn.rotation);
                    if (audio_laser_delay >= 5) {
                        bullet_two.Play();
                        audio_laser_delay = 0;
                    } else {
                        audio_laser_delay ++;
                    }
                    Destroy(bulletL, 3f);
                    ScoreSystem.laserTimer--;
                    if (ScoreSystem.laserTimer == 0) {
                        laserFlag = false;
                        laserStart = false;
                        ScoreSystem.laserBuffer = 0;
                        ScoreSystem.laserGo = false;
                        ScoreSystem.player_laser_ready_flag = true;
                        laserStartAnime.gun1_back(Gun);
                        laserStartAnime.gun2_back(laserGun);
                    }
                }
            } else {
                laserStart = false;
            }
        }
    }
}
