using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class laserStartAnime : MonoBehaviour {

    public static void gun1(GameObject Gun) {
        Gun.transform.Translate(0.3f, 0f, 0f);
    }

    public static void gun2(GameObject laserGun) {
        laserGun.transform.Translate(0f, 0f, 0.9f);
    }

    public static void gun1_back(GameObject Gun) {
        Gun.transform.Translate(-0.3f, 0f, 0f);
    }

    public static void gun2_back(GameObject laserGun) {
        laserGun.transform.Translate(0f, 0f, -0.9f);
    }
}
