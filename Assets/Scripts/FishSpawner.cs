using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject commonFish;
    public GameObject uncommonFish;
    public GameObject rareFish;
    public GameObject epicFish;
    public GameObject legendaryFish;

    private GameObject fishToSpawn;

    private int randomTemp;

    public static List<GameObject> fish = new List<GameObject>();


    void Start()
    {
        SpawnFish();
        Instantiate(fishToSpawn, transform);
    }

    //when the player collides with the spawn thing, spawn fishies.


    void SpawnFish()
    {
        randomTemp = Random.Range(1, 31); 
        {
            if (randomTemp <= 12)
            {
                fishToSpawn = commonFish;
            }
            else if (randomTemp <= 21)
            {
                fishToSpawn = uncommonFish;
            }
            else if (randomTemp <= 26)
            {
                fishToSpawn = rareFish;
            }
            else if (randomTemp <= 29)
            {
                fishToSpawn = epicFish;
            }
            else
            {
                fishToSpawn = legendaryFish;
            }

        }
    }

    
}
