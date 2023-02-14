using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
   

    private void Start()
    {


    }
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {   // if an object goes past the players view, removes the object.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); 
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
