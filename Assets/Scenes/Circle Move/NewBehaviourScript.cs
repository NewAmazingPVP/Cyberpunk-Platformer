using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this speed as needed
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Add SpriteRenderer if not already present
        if (GetComponent<SpriteRenderer>() == null)
        {
            gameObject.AddComponent<SpriteRenderer>();
            Debug.Log("SpriteRenderer added to the GameObject.");
        }

        // Add Rigidbody2D if not already present
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
            Debug.Log("Rigidbody2D added to the GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move the GameObject horizontally
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0f) * moveSpeed;
        rb.velocity = movement;

        // You can add more functionality here based on user input or other conditions
    }
}
