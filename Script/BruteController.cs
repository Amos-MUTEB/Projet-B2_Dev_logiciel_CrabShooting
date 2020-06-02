using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BruteController : MonoBehaviour
{
    public Animator animator;
    public float speed = 4;
    public Vector3 rotation;
    public GameObject deathScreen;
    public float speedBullet;
    public GameObject SphereBullet;
    public GameObject bullet;
    public Transform bulletSpawnBrute;
    public AudioSource gunshot;

    public int lifes;
    public Text lifesText;
    public Text lifesText2;

    // Start is called before the first frame update
    void Start()
    {
        rotation.y = 280f;
        lifes = 3; // set start to 3 lifes
        UpdateLifesText();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isMoving", true);
            transform.Rotate(rotation * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            animator.SetBool("isMoving", true);
            transform.Translate(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            animator.SetBool("isMoving", true);
            transform.Rotate(-rotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isMoving", true);
            transform.Translate(0, 0, -1f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject currentBullet = Instantiate(bullet, bulletSpawnBrute.position, Quaternion.identity) as GameObject;
            currentBullet.GetComponent<Rigidbody>().AddForce(bulletSpawnBrute.transform.forward * speedBullet); // 
            gunshot.Play(); // play gunshout audio     
        }
    }
    public void UpdateLifesText() // updates lifes UI text
    {
        lifesText.text = DBManager.username + " : " + lifes + "\nScore : 20";
    }

    public void GameOver()
    {
        deathScreen.SetActive(true);
        lifesText2.text = DBManager.username + ", You Died" + "\nGAME OVER";
    }
}
