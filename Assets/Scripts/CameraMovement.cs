using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Hook inv;
    [SerializeField] GameObject hook;

    Spawner spawner;
    [SerializeField] GameObject spawnPoint;

    [SerializeField] GameObject boatZone;

    public float speed = 2;

    public bool isBoating;

    void Awake()
    {
        inv = hook.GetComponent<Hook>();

        spawner = spawnPoint.GetComponent<Spawner>();
    }

    void Start()
    {
        isBoating = true;
    }


    void Update()
    {
        if (isBoating == false)
        {
            boatZone.SetActive(false);

        }
        else
        {
            boatZone.SetActive(true);
        }


        if (isBoating == false)
        {
            if (Input.GetMouseButton(0))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }



            if (Input.GetMouseButton(1))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
     {
        if (other.gameObject.CompareTag("Surface"))
        {
            transform.position = new Vector3(0, 20, 0);
            isBoating = true;

            GameObject[] killFish = GameObject.FindGameObjectsWithTag("Fish");
            foreach (GameObject kFish in killFish)
            {
                GameObject.Destroy(kFish);
            }
            StartCoroutine(Wait());

            spawner.SpawnFish();
            inv.ResetInventory();

        }
     }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Spawn Fish");

    }

    
}
