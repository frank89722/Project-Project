using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemydestroy : MonoBehaviour{
    public int heal;
    private float healCounter;
    private float laserCounter;
    private float damageeee;
	private float max_heal = 100f;
    private float cur_heal = 0f;
    public GameObject healthbar;
	private int count;
	public string entag;
    public string entag2;
    
    void Start(){
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
        healCounter = heal;
    }
    
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag (entag)) {
            damageCounter(2);
            damageeee = 2;
        } else if (other.gameObject.CompareTag(entag2)){
            damageCounter(2);
            damageeee = 2;
        }
    }

    void sethealthbar(){
        cur_heal -= 100/healCounter*damageeee;
		float calc_heal = cur_heal / max_heal;
        sethealthbar(calc_heal);
    }
    public void sethealthbar(float myhealth){
        healthbar.transform.localScale = new Vector3(myhealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
    }

    void damageCounter(int bulletDamage){
        heal -= bulletDamage;

        if (heal <= 0) {
            Destroy(gameObject);
            ScoreSystem.count++;
        }
        sethealthbar();
    }
}
