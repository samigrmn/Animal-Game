using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    private int MaxRange = 20;
    private int MinRange = -20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRamdomAnimal();
        //}
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(MinRange, MaxRange), 0, MaxRange);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
