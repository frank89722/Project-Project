using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser2 : MonoBehaviour
{
    public GameObject Game;
    public GameObject laser;
    public int s;
    public float b;
    public int g;
    public int timerx;


    // Use this for initialization
    void Start()
    {

       g = 0;

    }

    // Update is called once per frame
    void Update()
    {
        g++;
        laser.transform.Rotate(0, 3, 0);
   /*     if (g >= 100)
        {
            Destroy(GameObject.FindWithTag("wow"));
        }*/
        if (g >= 300)
        {
            var hpobj = Instantiate(Game, new Vector3(Random.Range(-6f, 6f), 0.5f, Random.Range(-6f, 6f)), Game.transform.rotation);
            hpobj.gameObject.tag = "wow";
            g = 0;
        }
    }
}

