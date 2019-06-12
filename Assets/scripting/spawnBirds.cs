using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBirds : MonoBehaviour
{

    public GameObject birds;
    float randomY;
    Vector2 wheretoSpawn;
    public float spawnRate;
    float nextSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time * spawnRate;
            randomY = Random.Range(5.5f, -5.5f);
            wheretoSpawn = new Vector2(transform.position.x, randomY);
            Instantiate(birds, wheretoSpawn, Quaternion.identity);
        }
    }
}
