using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zLimitMin = 0.0f;
    public float zLimitMax = 14.0f;

    public GameObject projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.forward);

        if (transform.position.x < -xRange)
            transform.position = new(-xRange, transform.position.y, transform.position.z);

        if (transform.position.x > xRange)
            transform.position = new(xRange, transform.position.y, transform.position.z);

        if (transform.position.z < zLimitMin)
            transform.position = new(transform.position.x, transform.position.y, zLimitMin);

        if (transform.position.z > zLimitMax)
            transform.position = new(transform.position.x, transform.position.y, zLimitMax);

        if (Input.GetKeyDown(KeyCode.Space))
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position + Vector3.forward * 1.2f, projectilePrefab.transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Projectile"))
        {
            Debug.Log("Game Over!");
        }
    }
}