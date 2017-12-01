using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ispawner : MonoBehaviour {
    public static void SpawnEnemy(GameObject newEnemy) {
        Instantiate(newEnemy, new Vector3(Random.Range(-8f, 8f), 0.5f, Random.Range(-8f, 8f)), newEnemy.transform.rotation);
    }
}
