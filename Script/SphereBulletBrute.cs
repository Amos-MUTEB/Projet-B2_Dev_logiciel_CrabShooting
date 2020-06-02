using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBulletBrute : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Archero") // if bullet hits enemy
        {
            ArcheroController ArcheroController = collision.gameObject.GetComponent<ArcheroController>();
            ArcheroController.lifes--; // lose a life
            if (ArcheroController.lifes == 0) // if no more lifes
            {
                ArcheroController.GameOver();
                Time.timeScale = 0.0f; // stop game
            }
            ArcheroController.UpdateLifesText(); // update lifes text
            Destroy(this.gameObject);
        }
        else // if bullet hits anything else
        {
           // Destroy(this.gameObject);
        }
    }
}
