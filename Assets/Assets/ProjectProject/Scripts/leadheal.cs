using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leadheal : MonoBehaviour {
    public static float max_heal = 100f;
    public static float cur_heal = 2f;
    public GameObject healthbar;
    public AudioSource player_hurt;
    public AudioSource gameover;
    public int count;
    public string tag1;
    public string tag2;
    public string tag3;

    void Start () {
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
    }

    private void FixedUpdate(){
        sethealthbar();
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag(tag1)) {
            cur_heal -= 2;
            player_hurt.Play();
            if (cur_heal <= 0) {
                Pause.gOver = true;
                gameover.Play();
            }
        } else if (other.gameObject.CompareTag(tag2)) {
            cur_heal -= 4;
            player_hurt.Play();
            if (cur_heal <= 0) {
                Pause.gOver = true;
                gameover.Play();
            }
        } else if (other.gameObject.CompareTag(tag3)) {
            cur_heal -= 4;
            player_hurt.Play();
            if (cur_heal <= 0) {
                Pause.gOver = true;
                gameover.Play();
            }
        }
    }
    void sethealthbar(){
        float calc_heal = cur_heal / max_heal;
        sethealthbar(calc_heal);
    }
    public void sethealthbar(float myhealth){
        healthbar.transform.localScale = new Vector3(myhealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
    }
}


