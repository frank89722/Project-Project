using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodpackage : MonoBehaviour{
    public GameObject Game;
    public GameObject package;
    public int s;
    public float b;
    public static int x;
    public int timerx;
    public int heal = 50;
    public float max_heal = 100f;
    public float cur_heal = 0f;
    public GameObject healthbar;

    // Use this for initialization
    void Start(){
        s = 45;
        x = 0;
        b = 0.4f;
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);

    }

    // Update is called once per frame
    void FixedUpdate(){
        if (s <= 360){
            package.transform.rotation = Quaternion.Euler(0, s, 45);
            s += 1;
        }
        else if (s >= 360){
            s = 0;
            package.transform.rotation = Quaternion.Euler(0, s, 45);
        }
        if (x == 599){
            Destroy(GameObject.FindWithTag("healpack"));
        }
        if (x >= 600) {
            var hpobj = Instantiate(Game, new Vector3(Random.Range(-8f, 8f), 0.5f, Random.Range(-8f, 8f)), Game.transform.rotation);
            hpobj.gameObject.tag = "healpack";
            x = 0;
        } else {
            x += 1;
            timerx = x;
        }

    }

    void Update(){
        sethealthbar();
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
            leadheal.heal += 5;
            leadheal.cur_heal += 10f;
        }
    }
    void sethealthbar() {
        cur_heal -=0.4199999f;
        float calc_heal = cur_heal / max_heal;
        sethealthbar(calc_heal);
    }
    public void sethealthbar(float myhealth) {
        healthbar.transform.localScale = new Vector3(myhealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
    }
}

