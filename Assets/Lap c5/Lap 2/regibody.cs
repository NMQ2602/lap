using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regibody : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Chạm: " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trig: " + other.gameObject.name);
    }


}