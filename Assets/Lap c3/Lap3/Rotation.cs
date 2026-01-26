using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretRotation : MonoBehaviour
{
    public Transform target;

    public float rotateSpeed = 180f;
    public bool smoothRotation = false;

    void Update()
    {
        if (target == null) return;

        Vector3 direction = target.position - transform.position;
        direction.y = 0;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        if (smoothRotation)
        {
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotateSpeed * Time.deltaTime
            );
        }
        else
        {
            transform.rotation = targetRotation;
        }
    }
}
