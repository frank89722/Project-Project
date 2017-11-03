using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using SCC;


public class enemydestroy : MonoBehaviour
{
    public static int heal;
	public float max_heal = 100;
    public float cur_heal = 0;
    public GameObject healthbar;
	public int count;
	public int b;
    
    void Start()
    {
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
        heal = 20;
		count = 0;
    }
    
    public void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag ("Pick Up")) {
			heal--;

			sethealthbar ();
			if (heal == 0) {
				Destroy (gameObject);
				count++;
				b = count;
				//SCC.ScoreSystem.Counter(b);
			}
		}
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
