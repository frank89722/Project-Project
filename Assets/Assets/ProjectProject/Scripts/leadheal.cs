using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leadheal : MonoBehaviour {
    public int heal = 1000;
    public float max_heal = 100f;
    public float cur_heal = 0f;
    public GameObject healthbar;
    public int count;
    public string tag;
    // Use this for initialization
    void Start () {
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            heal--;

            if (heal == 0)
            {
                Destroy(gameObject);
                ScoreSystem.count++;
            }
            sethealthbar();
        }
    }
    void sethealthbar()
    {
        cur_heal -= 2f;
        float calc_heal = cur_heal / max_heal;
        sethealthbar(calc_heal);
    }
    public void sethealthbar(float myhealth)
    {
        healthbar.transform.localScale = new Vector3(myhealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
    }
}


