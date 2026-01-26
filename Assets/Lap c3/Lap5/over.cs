using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class over : MonoBehaviour
{
    public hp playerHealth;
    public GameObject gameOverPanel;

    void OnEnable()
    {
        playerHealth.OnPlayerDied += ShowGameOver;
    }

    void OnDisable()
    {
        playerHealth.OnPlayerDied -= ShowGameOver;
    }

    void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}

