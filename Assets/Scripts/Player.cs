using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canMove = true; // Defines if the player can move
    public bool canBeDestroyed = true; // Defines if the player can be destroyed

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            HandleInput(); // Handles player input
        }
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
        if (other.transform.tag == "Enemy" && canBeDestroyed) // If collision with enemy, destroy player
        {
            Destroy(gameObject);
            FindObjectOfType<SceneMachine>().ReloadScene();
        }
    }
}
