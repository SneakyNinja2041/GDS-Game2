using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Hook inventory;
    [SerializeField] GameObject player;

    void Awake()
    {
        inventory = player.GetComponent<Hook>();
    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (inventory.inventoryFull == false)
            {
                // record how much money the fish gives player
                Destroy(this.gameObject);
            }

            if (inventory.inventoryFull == true)
            {
                return;
            }

        }


    }
}
