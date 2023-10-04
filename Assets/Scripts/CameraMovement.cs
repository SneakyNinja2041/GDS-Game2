using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject hook;

    public float speed = 2;

    public TextMeshProUGUI inventoryText;

    public bool isBoating = true;

    void Start()
    {
        GameObject hi = Instantiate(hook, transform);
        hi.GetComponent<Hook>().inventoryText = inventoryText;
        hook.transform.parent = gameObject.transform;
    }


    void Update()
    {
        if (isBoating == true)
        {
            // turn off the hook sprite

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

        }      
    }
    // if player collides with the top of the game section, then set bool isBoating to true, and move the player transform up to the boating section
    // maybe have a lil scene that appears on the screen for a few seconds to make it less jarring
}
