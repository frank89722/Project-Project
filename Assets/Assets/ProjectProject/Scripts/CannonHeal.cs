using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonHeal : MonoBehaviour {

    public float max_heal = 100f;
    public float cur_heal = 0f;
    public static float multipleDamage;
    public GameObject healthbar;
    public int count;
    // Use this for initialization
    void Start()
    {
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
    }

    private void FixedUpdate()
    {
        
        if (cur_heal > max_heal)
        {
            cur_heal = max_heal;
        }
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pick Up") | other.gameObject.CompareTag("Pick Up2")){

            cur_heal -= multipleDamage;
            if (cur_heal <= 0){
                Destroy(gameObject);
                ScoreSystem.count++;
            }
            sethealthbar();
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
