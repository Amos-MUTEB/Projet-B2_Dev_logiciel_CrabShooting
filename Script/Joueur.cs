using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public Animator animator;
    public float speed = 4;
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation.y = 280f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.J))
        {
            animator.SetBool("is moving", true);
            transform.Rotate(rotation * Time.deltaTime);
        }
        else
        {
            animator.SetBool("is moving", false);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            animator.SetBool("is moving", true);
            transform.Translate(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.G))
        {
            animator.SetBool("is moving", true);
            transform.Rotate(-rotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.H))
        {
            animator.SetBool("is moving", true);
            transform.Translate(0, 0, -1f);
        }
    }
}
