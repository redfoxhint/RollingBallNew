﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float minSpawn = -70f;
    private float maxSpawn = 70f;

    [SerializeField] private int amountToSpawn;

    [SerializeField] private GameObject enemyPrefab;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnEnemy(amountToSpawn);
        }
    }

    public void SpawnEnemy(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 spawnPosition = Utility.PickSpawnLocation(minSpawn, maxSpawn);
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
