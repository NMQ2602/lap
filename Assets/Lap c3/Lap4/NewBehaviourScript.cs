using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera mainCamera;
    public TextMeshProUGUI angleText;

    float angle;

    void Update()
    {
        Vector3 mouseWorld =
            mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction =
            mouseWorld - transform.position;

        angle = Vector2.SignedAngle(Vector2.up, direction);


        transform.rotation = Quaternion.Euler(0, 0, angle);


        angleText.text = "goc: " + angle.ToString("F1") + "°";
    }
}

