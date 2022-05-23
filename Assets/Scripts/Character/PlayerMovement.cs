using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody2D rb;

    public GameObject Door;


    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {

        rb.AddForce(Vector2.right * moveSpeed * horizontalInput);

        rb.AddForce(Vector2.up * moveSpeed * verticalInput);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        TestKey testKey = collision.gameObject.GetComponent<TestKey>();

        if (testKey)
        {

            Destroy(collision.gameObject);
            Door.SetActive(false);

        }

    }

}
