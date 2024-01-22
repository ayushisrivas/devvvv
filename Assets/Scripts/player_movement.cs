using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField]
    public GameManager gm;
    public bool isgrounded;
    public bool iscoined;
    [SerializeField]
    private float move_speed=100;
    [SerializeField]
    private float jump_speed = 1500;
   
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        move_speed = 80;
        jump_speed=1500;
    }

    // Update is called once per frame
    void Update()
    {
        if (isgrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jump_speed , ForceMode2D.Force);

            }
        }
        float movement = Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector3(movement, 0, 0) * move_speed );


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
            isgrounded = true;

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
            isgrounded = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.layer == LayerMask.NameToLayer("coin"))
            iscoined = true;
        if (iscoined == true)
        { gm.score += 1;
            iscoined = false; }
    }
    
}
