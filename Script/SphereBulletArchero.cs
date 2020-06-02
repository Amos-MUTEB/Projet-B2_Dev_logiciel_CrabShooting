using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBulletArchero : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Brute") // if bullet hits enemy
        {
            BruteController BruteController = collision.gameObject.GetComponent<BruteController>();
            BruteController.lifes--; // lose a life
            if (BruteController.lifes == 0) // if no more lifes
            {
                BruteController.GameOver();
                Time.timeScale = 0.0f; // stop game
            }
            BruteController.UpdateLifesText(); // update lifes text
            Destroy(this.gameObject);
        }
        else // if bullet hits anything else
        {
            // Destroy(this.gameObject);
        }
    }
}
