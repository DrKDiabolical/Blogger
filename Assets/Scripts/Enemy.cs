using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool moveRight = true; // Defines if the enemy moves right or left
    float velocity; // Defines the velocity that the enemy moves

    void Start()
    {
        if (moveRight)
        {
            velocity = 1f;
        }
        else {
            velocity = -1f;
        }
        InvokeRepeating("Move", 0, 1); // Moves the enemy every 1 second
    }

    // Moves the enemy in the defined velocity
    void Move()
    {
        transform.Translate(new Vector2(velocity, 0f));
    }

    // Handles collision with other objects
    void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == "EnemyCleaner") // If collision with EnemyCleaner, destroy enemy
        {
            Destroy(gameObject);
        }
    }
}
