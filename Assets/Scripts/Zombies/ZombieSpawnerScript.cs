// using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnerScript : MonoBehaviour {

    public GameObject enemy;
    float randX, randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start() {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-84.5f, 57.0f);
            randY = Random.Range(35.5f, -50.0f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, enemy.transform.rotation);
        }
    }
}
