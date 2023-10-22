using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public GameObject player;
    CameraMovement camMove;

    

    void Awake()
    {
        camMove = player.GetComponent<CameraMovement>();
       
    }


  

    public void RoundStart()
    {      
        camMove.isBoating = false;
        player.transform.position = new Vector3(0, 0, 0);
        
    }
}
