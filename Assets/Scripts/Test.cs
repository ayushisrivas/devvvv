using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
 
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("entered a gameobject"+collision.gameObject.name);
    //}
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    Debug.Log("exit a gameobject" + collision.gameObject.name);
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter a gameobject" + collision.gameObject.name);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("exit a gameobject" + collision.gameObject.name);
    }
}


