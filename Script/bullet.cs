using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy") // if bullet hits enemy
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Player") // if bullet hits enemy
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.lifes--; // lose a life
            if (playerController.lifes == 0) // if no more lifes
            {
                playerController.GameOver();
                Time.timeScale = 0.0f; // stop game
            }
            playerController.UpdateLifesText(); // update lifes text
            Destroy(this.gameObject);
        }
        else // if bullet hits anything else
        {
            Destroy(this.gameObject);
        }
    }
}
