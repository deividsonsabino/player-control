using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody playerRb;
    private float Zbound = 6f;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        if (transform.position.z > Zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Zbound);
        }

        if (transform.position.z < -Zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -Zbound);
        }
    }
}
