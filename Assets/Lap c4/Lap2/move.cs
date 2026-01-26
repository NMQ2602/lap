using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move1 : MonoBehaviour
{
    public float speed = 5f;

    private Vector3 inputDirection;

    void Update()
    {
        float a = Input.GetAxisRaw("Horizontal");
        float b = Input.GetAxisRaw("Vertical");  
        inputDirection = new Vector3(a, b, 0);

        if (inputDirection.magnitude > 1)
        {
            inputDirection = inputDirection.normalized;
        }


        transform.position += inputDirection * speed * Time.deltaTime;
    }

}
