using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodpackage : MonoBehaviour
{
    public GameObject Game;
    public GameObject package;
    public int s;
    public float b;
    public float x;

    // Use this for initialization
    void Start()
    {
        s = 45;
        x = 0;
        b = 0.4f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (s <= 360)
        {
            package.transform.rotation = Quaternion.Euler(0, s, 45);
            s += 1;
        }
        else if (s >= 360)
        {
            s = 0;
            package.transform.rotation = Quaternion.Euler(0, s, 45);
        }
         if (x >= 600){
             Instantiate(Game, new Vector3(Random.Range(-8f, 8f), 0.5f, Random.Range(-8f, 8f)), Game.transform.rotation);
             x = 0;
         }
         else{
             x += 1;
         }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            leadheal.heal += 5;
            leadheal.cur_heal += 10f;
        }
    }
}

