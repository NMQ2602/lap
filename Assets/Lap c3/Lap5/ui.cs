using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ui : MonoBehaviour
{
    public hp playerHealth;
    public TextMeshProUGUI healthText;

    void OnEnable()
    {
        playerHealth.OnHealthChanged += UpdateHealthUI;
    }

    void OnDisable()
    {
        playerHealth.OnHealthChanged -= UpdateHealthUI;
    }

    void UpdateHealthUI(int health)
    {
        healthText.text = "HP: " + health;
    }
}

