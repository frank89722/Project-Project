using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControll : MonoBehaviour
{
    public float mSpeed;
    public Rigidbody rb;
    public GameObject bulletPrefab;
    public GameObject laserPrefab;
    public GameObject Gun;
    public GameObject laserGun;
    public Transform bulletSpawn;
    public Transform laserSpawn;
    public int delay;
    public int laserTimer;
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
            gameObject.transform.rotation = Quaternion.Euler(0f, 45f, 0f);
            transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        }
        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.D)){
            gameObject.transform.rotation = Quaternion.Euler(0f, 135f, 0f);
            transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        }
        else if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.S)){
            gameObject.transform.rotation = Quaternion.Euler(0f, 225f, 0f);
            transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        }
        else if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.W)){
            gameObject.transform.rotation = Quaternion.Euler(0f, 315f, 0f);
            transform.Translate(new Vector3(0, 0, 1) * mSpeed);
        }
        else if (Input.GetKey(KeyCode.W)){
            transform.position += Vector3.forward * mSpeed;
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A)) {
            transform.position += Vector3.left * mSpeed;
            gameObject.transform.rotation = Quaternion.Euler(0f, 270f, 0f);
        }
        else if (Input.GetKey(KeyCode.S)){
            transform.position += Vector3.back * mSpeed;
            gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetKey(KeyCode.D)){
            transform.position += Vector3.right * mSpeed;
            gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
    
        fire();
        laser();
    }



    void fire(){
        if (Input.GetKey(KeyCode.Space)){
            delay++;
            if (delay == 2){
                var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
                Destroy(bullet, 3f);
                delay = 0;
            }
        }
    }

    void laser(){
        if (Input.GetKey(KeyCode.L)) {
            laserStart = true;
        }
        if (laserStart == true) {
            if (ScoreSystem.laserGo == true) {
                //ScoreSystem.laserBuffer = 0;
                if (laserFlag == false) {
                    laserFlag = true;
                    laserTimer = 500;
                    laserStartAnime.gun1(Gun);
                    laserStartAnime.gun2(laserGun);
                }
                else if (laserFlag == true) {
                    var bulletL = (GameObject)Instantiate(laserPrefab, laserSpawn.position, laserSpawn.rotation);
                    Destroy(bulletL, 3f);
                    laserTimer -= 1;
                    if (laserTimer <= 0) {
                        laserFlag = false;
                        laserStart = false;
                        ScoreSystem.laserGo = false;
                        laserStartAnime.gun1_back(Gun);
                        laserStartAnime.gun2_back(laserGun);
                    }
                }
            }
        }
    }
}
