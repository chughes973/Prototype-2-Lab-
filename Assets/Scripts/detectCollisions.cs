using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) //called different function
    {
        //destroy both game objects upon collision with each other
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
