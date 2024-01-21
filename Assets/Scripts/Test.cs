using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Rigidbody2D rb;
    public Test2 t2;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        t2=GetComponent<Test2>();

    }

  
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position =new Vector3(transform.position.x-0.04f, transform.position.y, transform.position.z);   //changing position through transform
            //transform.Translate(new Vector3(transform.position.x - 0.04f, transform.position.y, transform.position.z));
            //rb.AddForce(Vector3.left);
            //rb.velocity = Vector3.left; 
            //rb.MovePosition(Vector3.left);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x + 0.04f, transform.position.y, transform.position.z);
        }
    }
}


