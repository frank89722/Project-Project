using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemydestroy : MonoBehaviour
{
    public int heal;
	public float max_heal = 100;
    public float cur_heal = 0;
    public GameObject healthbar;
	public int count;
    
    void Start()
    {
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
        heal = 20;
    }
    
	public void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag ("Pick Up")) {
			heal--;
			Debug.Log ("Heal:" + heal);
			if (heal == 0) {
				Destroy (gameObject);
				ScoreSystem.count++;
			}
			sethealthbar ();}
    }
    void sethealthbar(){
        cur_heal -= 5;
		float calc_heal = cur_heal / max_heal;
        sethealthbar(calc_heal);
    }
    public void sethealthbar(float myhealth)
    {
        healthbar.transform.localScale = new Vector3(myhealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
    }
}
