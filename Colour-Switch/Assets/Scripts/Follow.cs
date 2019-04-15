using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the player has surpassed the part of the camera that is on screen
        // the camera will move with the player.
       if (Player.position.y > transform.position.y)
       {
         transform.position = new Vector3(transform.position.x, Player.position.y, transform.position.z);  
       } 
    }
}
