using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    

    public int price = 0;

  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerStats.Money += price;
            Destroy(this.gameObject);

        }


    }
}
