using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    

    public float speed = 2;

   

    void Update()
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
