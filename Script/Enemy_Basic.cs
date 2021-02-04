using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Basic : MonoBehaviour
{

    public float moveSpeed = 1f;

    private int health;

    public Transform player;

    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 moveDirection;
    float lookAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        health = 3;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Projectile"))
        {
            Destroy(col.gameObject);
            health -= 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        moveDirection = player.position - transform.position;
        lookAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg - 90f;
        movement = moveDirection.normalized;
        if (health == 0)
        {
            Status.playerScore += 5;
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        rb.rotation = lookAngle;
        rb.MovePosition((Vector2)transform.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }
    
}
