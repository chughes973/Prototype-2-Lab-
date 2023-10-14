using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30;
    private float lowerBoundary = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (transform.position.z > topBoundary)
        {
            Destroy(gameObject); //object this script is applied to will disappear when outside the limit
        } else if (transform.position.z < lowerBoundary)
        {
            Destroy(gameObject);
        }
    }
}
