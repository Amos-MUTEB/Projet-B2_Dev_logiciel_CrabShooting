using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArcheroController : MonoBehaviour
{
    public Animator animator;
    public float speed = 4;
    public float speedBullet;
    public Vector3 rotation;
    public GameObject SphereBullet;
    public Transform bulletSpawnArchero;
    public AudioSource gunshot;
    public GameObject deathScreen;

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

        if (Input.GetKey(KeyCode.M))
        {
            animator.SetBool("is running", true);
            transform.Rotate(rotation * Time.deltaTime);
        }
        else
        {
            animator.SetBool("is running", false);
        }
        if (Input.GetKey(KeyCode.O))
        {
            animator.SetBool("is running", true);
            transform.Translate(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.K))
        {
            animator.SetBool("is running", true);
            transform.Rotate(-rotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            animator.SetBool("is running", true);
            transform.Translate(0, 0, -1f);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject currentBullet = Instantiate(SphereBullet, bulletSpawnArchero.position, Quaternion.identity) as GameObject;
            currentBullet.GetComponent<Rigidbody>().AddForce(bulletSpawnArchero.transform.forward * speedBullet); // 
            gunshot.Play(); // play gunshout audio     
        }
    }
    public void UpdateLifesText() // updates lifes UI text
    {
        lifesText.text = "Archero : " + lifes + "\nScore : 20";
    }

    public void GameOver()
    {
        deathScreen.SetActive(true);
        lifesText2.text = DBManager.username + ", You WIN" + "\nGo to the next level";
    }
}
