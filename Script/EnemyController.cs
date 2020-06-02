using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public AudioSource gunshot;
    public Transform bulletSpawnPos;

    public float randomTime;

    // Start is called before the first frame update
    void Start()
    {
        //finds player in the scene
        player = GameObject.Find("Player");

        //call shoot function every 5 seconds
        InvokeRepeating("Shoot", 5.0f, 5.0f);

    }

    // Update is called once per frame
    void Update()
    {
        // look towards player
        transform.LookAt(player.transform.transform, Vector3.up);
    }

    public void Shoot() // shoot bullet
    {
        GameObject currentBullet = Instantiate(bullet, bulletSpawnPos.position, Quaternion.identity) as GameObject;
        currentBullet.GetComponent<Rigidbody>().AddForce(bulletSpawnPos.transform.forward * 5000);
        gunshot.Play();
    }
}
