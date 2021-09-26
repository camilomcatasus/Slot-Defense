using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;

    public Transform[] spawnSpots;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    private float timeleft;

    private bool start;


    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }


    void Update()
    {

        if (timeBtwSpawns <= 0)
        {

            int randPos = Random.Range(0, spawnSpots.Length);

            int randEnemy = Random.Range(0, enemy.Length);

            Instantiate(enemy[randEnemy], spawnSpots[randPos].position, Quaternion.identity);

            timeBtwSpawns = startTimeBtwSpawns;

        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
            timeleft -= Time.deltaTime;

        }
    }
}
