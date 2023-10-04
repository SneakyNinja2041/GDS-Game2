using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public GameObject player;


    public void RoundStart()
    {
        //isBoating = false;  get reference to bool / the player inv from game 1
        player.transform.position = new Vector3(0, 0, 0);
    }
}
