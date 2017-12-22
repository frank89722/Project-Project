using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallHeal : MonoBehaviour {
    public float max_heal = 20f;
    public float cur_heal = 0f;
    public static float multipleDamage;
    public int count;

    void Start() {
        cur_heal = max_heal;
        InvokeRepeating("healbar", 1f, 1f);
    }

    private void FixedUpdate() {

        if (cur_heal > max_heal) {
            cur_heal = max_heal;
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pick Up") | other.gameObject.CompareTag("Pick Up2")) {
            cur_heal -= multipleDamage;
            if (cur_heal <= 0) {
                Destroy(gameObject);
            }
        }
    }
}

