using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private PlayerDamageManager dm;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float horizontalInput;
    private float verticalInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dm = GetComponent<PlayerDamageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        movement.x = horizontalInput;
        movement.y = verticalInput;
    }

    private void FixedUpdate()
    {
        if(!dm.isDead)
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
