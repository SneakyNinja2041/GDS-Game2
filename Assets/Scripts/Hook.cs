using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Hook : MonoBehaviour
{
    public int maxFish = 2;
    private static int inventory = 0;
    

    public bool inventoryFull = false;

    private BoxCollider2D hookCollider;
 

    public TextMeshProUGUI inventoryText;

    

    void Start()
    {
        hookCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (inventory == maxFish)
        {
            inventoryFull = true;
            hookCollider.enabled = false;
            
        }
        else
        {
            inventoryFull = false;
            hookCollider.enabled = true;
        }

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;

        inventoryText.text = "FISH: " + inventory + "/" + maxFish;
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

    public void ResetInventory()
    {
        inventory = 0;
        Debug.Log("Inventory Reset");
    }

}
