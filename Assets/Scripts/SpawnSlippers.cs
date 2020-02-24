using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlippers : MonoBehaviour {

    public GameObject[] slipperArray;
    float randX;
    Vector2 spawningArea;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    private float nextActionTime = 0.0f;
    public float periodSec = 20f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
      
            if (Time.time > nextSpawn)
            {
            // Spawn slippers at the given area after some seconds
                nextSpawn = Time.time + spawnRate;
                randX = Random.Range(29f, 64.6f);
                spawningArea = new Vector2(randX, transform.position.y);
                Instantiate(slipperArray[Random.Range(0, 6)], spawningArea, Quaternion.identity);

            }

            if (Time.time > nextActionTime)
        {
            nextActionTime += periodSec;
            spawnRate -= .05f;

             if (spawnRate <= 0.2f)
            {
                spawnRate = 0.2f;
            }
        }

            
    }
}
