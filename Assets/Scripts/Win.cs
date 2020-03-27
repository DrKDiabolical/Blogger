using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject winCanvas; // Contains canvas gameobject

    void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == "Player") // If player collides with object, set winCanvas to active and disable player movement and vulnerability
        {
            winCanvas.SetActive(true);
            FindObjectOfType<Player>().canMove = false;
            FindObjectOfType<Player>().canBeDestroyed = false;
        }
    }
}
