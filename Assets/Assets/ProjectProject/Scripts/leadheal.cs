﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leadheal : MonoBehaviour {
    public static int heal = 50;
    public float max_heal = 100f;
    public static float cur_heal = 2f;
    public GameObject healthbar;
    public int count;
    public string tag;
    // Use this for initialization
    void Start () {
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
    }

    private void Update()
    {
        sethealthbar();
        if (cur_heal >= max_heal) {
            cur_heal = max_heal;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            heal--;
            cur_heal -= 2;
            if (heal == 0)
            {
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


