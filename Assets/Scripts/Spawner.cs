using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private float spawnRadiusX = 10f;
    [SerializeField] private float spawnRadiusY = 100f;

    [SerializeField] private GameObject commonFish;
    [SerializeField] private GameObject uncommonFish;
    [SerializeField] private GameObject rareFish;
    [SerializeField] private GameObject epicFish;
    [SerializeField] private GameObject legendaryFish;
    private GameObject fishToSpawn;

    [SerializeField] GameObject player;
    CameraMovement surface;

    private int randomTemp;

    private static List<GameObject> fish = new List<GameObject>();

    void Start()
    {
        surface = player.GetComponent<CameraMovement>();

        //SpawnFish();

    }

    public void GetFish()
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

    public void SpawnFish()
    {
        

        for (int i = 0; i < 10; i++)
        {
            float randomX = Random.Range(-spawnRadiusX, spawnRadiusX);
            float randomY = Random.Range(-spawnRadiusY, spawnRadiusY);
            Vector2 spawnPos = (Vector2)transform.position + new Vector2(randomX, randomY);
        
            GetFish();
            Instantiate(fishToSpawn, spawnPos, Quaternion.identity);
        }
       
    }




}
