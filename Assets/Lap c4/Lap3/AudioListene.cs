using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAudioListener : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        // M: Mute / Unmute toàn bộ âm thanh
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0f : 1f;
        }

        // P: Pause / Resume toàn bộ âm thanh
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            AudioListener.pause = isPaused;
        }
    }
}
