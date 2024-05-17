using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    //¹°¸®´Â vector
    Rigidbody AAA;
    public float jump;
    public float speed;
    float h;
    float v;
    Vector3 move;
  //  GameObject trampalin = Collision.;



    void Start()
    {
        AAA = GetComponent<Rigidbody>();
        //AAA.velocity = Vector3.right*5;
    }


    void Update()
    {
        //float xMove = Input.GetAxis("Horizontal");
        //float zMove = Input.GetAxis("Vertical");



        //if (Input.GetButtonDown("Jump"))
        //{
        //    AAA.AddForce(Vector3.up * jump, ForceMode.Impulse);
        //}

        //h = Input.GetAxisRaw("Horizontal");
        //v = Input.GetAxisRaw("Vertical");

        //move = new Vector3(h, 0 ,v);

        //AAA.AddForce(move * speed, ForceMode.Impulse);
        //if(OnCollisionEnter.)
    }

    
}
