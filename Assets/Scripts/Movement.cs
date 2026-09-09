using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Movement : MonoBehaviour
{
    public float Speed = 5;
    
    public Rigidbody2D RB;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 vel = new Vector2(0,0);
        
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }
      
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }
        
        RB.linearVelocity = vel;
        
        // The main Deafult player movement I've used throughout a lot of players codes
    }
}
