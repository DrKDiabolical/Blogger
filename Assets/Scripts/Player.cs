using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        HandleInput(); // Handles player input
    }

    // Handles the input and movement of the player, including movement boundaries
    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0f, 1f));
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0f, -1f));
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(1f, 0f));
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-1f, 0f));
        }

        var clampPosition = new Vector2(Mathf.Clamp(transform.position.x, 0, 8), Mathf.Clamp(transform.position.y, 0, 15));
        transform.position = clampPosition;
    }

    // Handles collision with other objects
    void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == "Enemy") // If collision with enemy, destroy player
        {
            Destroy(gameObject);
        }
    }
    
    // Handles collision with other triggers
    void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "WinArea") // If collision with WinArea, log that player won
        {
            // TODO: Add win scenario, remove test log
            Debug.Log("You Win!");
        }
    }
}
