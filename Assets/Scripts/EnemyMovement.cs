using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;
    private Transform player;
    private Vector2 moveDirection;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = (player.position - transform.position).normalized;
    }

    private void FixedUpdate()
    {
        if(!player.GetComponent<PlayerDamageManager>().isDead)
            rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
