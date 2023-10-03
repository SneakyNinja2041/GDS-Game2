using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public int maxFish = 2;
    public int inventory = 0;
    public int startInventory = 0;

    public bool inventoryFull = false;

    void Start()
    {
        inventory = startInventory;
    }

    void Update()
    {
        if (inventory == maxFish)
        {
            inventoryFull = true;
        }
        else
        {
            inventoryFull = false;
        }

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fish"))
        {
            if (inventoryFull == false)
            {
                inventory++;
            }
        }
    }

}
