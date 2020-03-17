using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] bool moveRight = true; // Defines if the enemy moves right or left
    float direction; // Defines the direction that the enemy moves

    void Start()
    {
        if (moveRight)
        {
            direction = 1f;
        }
        else {
            direction = -1f;
        }
        InvokeRepeating("Move", 0, 1); // Moves the enemy every 1 second
    }

    // Moves the enemy in the defined direction
    void Move()
    {
        transform.Translate(new Vector2(direction, 0f));
    }
}
