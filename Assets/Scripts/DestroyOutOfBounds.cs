using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30; // upper boundary of game objects
    private float lowerBoundary = -10; // lower boundary of game objects
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If an object goes past players view in game, remove that object
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject); //object this script is applied to will disappear when outside the limit
        }
        else if (transform.position.z < lowerBoundary)
        {
            Debug.Log("Game Over"); //tells us game over when object goes out of players view
            Destroy(gameObject);
        }
    }
}
