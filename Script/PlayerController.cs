using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Transform bulletSpawnPos;
    public GameObject bullet;
    public AudioSource gunshot;
    public GameObject deathScreen;

    public int lifes;
    public Text lifesText;

    // Start is called before the first frame update
    void Start()
    {
        lifes = 3; // set start to 3 lifes
        UpdateLifesText();
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit raycastHit;
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 1000.0f);

        //Ray r = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Input.GetKeyDown(KeyCode.Mouse0)) // if left-click, shoot gun
        {
            GameObject currentBullet = Instantiate(bullet, bulletSpawnPos.position, Quaternion.identity) as GameObject;
            currentBullet.GetComponent<Rigidbody>().AddForce(bulletSpawnPos.transform.forward * 5000); // 
            gunshot.Play(); // play gunshout audio      

        }
    }

    public void UpdateLifesText() // updates lifes UI text
    {
        lifesText.text = "Player : " + lifes+ "\nScore : 500" ;
    }

    public void GameOver()
    {
        deathScreen.SetActive(true);
    }

}
