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

    public static bool Attack = false;

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

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {

            transform.localRotation = Quaternion.Euler(0, 180, 0);

        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            transform.localRotation = Quaternion.Euler(0, 0, 0);

        }

    }

    private void FixedUpdate()
    {

        rb.AddForce(Vector2.right * moveSpeed * horizontalInput);

        rb.AddForce(Vector2.up * moveSpeed * verticalInput);

        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        KeyDoor keydoor = collision.gameObject.GetComponent<KeyDoor>();

        if (keydoor)
        {

            Destroy(collision.gameObject);
            Door.SetActive(false);

        }       

    }

}
