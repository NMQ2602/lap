using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollisionDemo : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision với: " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger với: " + other.gameObject.name);
    }
}

