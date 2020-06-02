using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public float speed = 100f;
    public float speed2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(Vector3.forward * speed2);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Brute") // if bullet hits brute
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else // if bullet hits anything else
        {
            Destroy(this.gameObject);
        }
    }
}