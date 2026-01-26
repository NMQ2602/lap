using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Intro: MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource music;
    public string gameplayScene = "Game";

    void Start()
    {
        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.loopPointReached += OnVideoEnd;

        videoPlayer.Prepare();
    }

    void OnPrepared(VideoPlayer vp)
    {
        vp.Play();
        music.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        LoadGameplay();
    }

    public void SkipIntro()
    {
        LoadGameplay();
    }

    void LoadGameplay()
    {
        music.Stop();
        SceneManager.LoadScene(gameplayScene);
    }
}
