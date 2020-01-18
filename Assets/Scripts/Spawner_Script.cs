using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Script : MonoBehaviour {


    public GameObject boulder;
    public GameObject fox;
    public GameObject bear;
    public GameObject truck;

    float randX;
    int randIndex;
    float nextSpawn = 0.0f;
    Vector2 spawnLocation;
    public float spawnRate = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-7.0f, 7.5f);
            randIndex = Random.Range(1, 5);
            spawnLocation = new Vector2(randX, transform.position.y);
            if (randIndex == 1)
                Instantiate(boulder, spawnLocation, Quaternion.identity);
            else if (randIndex == 2)
                Instantiate(bear, spawnLocation, Quaternion.identity);
            else if (randIndex == 3)
                Instantiate(fox, spawnLocation, Quaternion.identity);
            else if (randIndex == 4)
            {
                Instantiate(truck, spawnLocation, Quaternion.identity);
            }
        }

	}
}
