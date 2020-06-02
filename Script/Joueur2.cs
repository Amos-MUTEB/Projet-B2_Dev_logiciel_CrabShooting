using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur2 : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start(){


    }

    // Update is called once per frame
    void Update(){
        HandleMovement();
    }

    private void HandleMovement()
    {
        float slowdown = speed * Time.deltaTime;

        this.transform.Translate(new Vector3(Input.GetAxis("Horizontal") * slowdown, 0, Input.GetAxis("Vertical") * slowdown));
    }
}
