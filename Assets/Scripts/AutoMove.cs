using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AutoMove : MonoBehaviour
{
    
    public float speed = 5f;
    
   
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    
    // Used during my spike run during a very old game, which was made by vlogize
}
