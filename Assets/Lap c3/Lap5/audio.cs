using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public hp playerHealth;
    public AudioSource hitSound;

    void OnEnable()
    {
        playerHealth.OnHealthChanged += PlayHitSound;
    }

    void OnDisable()
    {
        playerHealth.OnHealthChanged -= PlayHitSound;
    }

    void PlayHitSound(int health)
    {
        hitSound.Play();
    }
}
