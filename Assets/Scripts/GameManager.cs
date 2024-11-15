using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;
    public GameObject enemy2;

    // Start is called before the first frame update
    void Start() {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
    }

    // Update is called once per frame
    void Update() {
        
    }

    void CreateEnemy() {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 8f, 0), Quaternion.identity);
        Instantiate(enemy2, new Vector3(Random.Range(-9f, 9f), 6f, 0), Quaternion.identity);
    }
}
