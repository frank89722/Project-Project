using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leadheal : MonoBehaviour {
    public static int heal = 50;
    public float max_heal = 100f;
    public static float cur_heal = 2f;
    public GameObject healthbar;
    public int count;
    public string tag1;
    public string tag2;
    // Use this for initialization
    void Start () {
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
    }

    private void FixedUpdate(){
        sethealthbar();
        if (cur_heal > max_heal) {
            cur_heal = max_heal;
            heal = 50;
        }
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag(tag1)) {
            //heal--;
            cur_heal -= 2;
            if (cur_heal <= 0) {
                Destroy(gameObject);
            }
        } else if (other.gameObject.CompareTag(tag2)) {
            cur_heal -= 5;
            if (cur_heal <= 0) {
                Destroy(gameObject);
            }
        }
    }
    void sethealthbar()
    {
        float calc_heal = cur_heal / max_heal;
        sethealthbar(calc_heal);
    }
    public void sethealthbar(float myhealth)
    {
        healthbar.transform.localScale = new Vector3(myhealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
    }
}


