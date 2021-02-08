using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public Transform[] SpawnPoint;

    private int Rand;
    private int RandPosition;

    public float StartTimeBetweenSpawn;
    private float TimeBetweenSpawns;

    private void Start()
    {
        TimeBetweenSpawns = StartTimeBetweenSpawn;
    }
    private void Update()
    {
        if(TimeBetweenSpawns <= 0)
        {
            Rand = Random.Range(0, Enemies.Length);
            RandPosition = Random.Range(0, SpawnPoint.Length);
            Instantiate(Enemies[Rand], SpawnPoint[RandPosition].transform.position, Quaternion.identity);
            TimeBetweenSpawns = StartTimeBetweenSpawn;
        }
        else
        {
            TimeBetweenSpawns -= Time.deltaTime;
        }
    }
}