using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ShowVideo1()
    {
        VideoStaticData.VideoName = "Video2";
        SceneManager.LoadScene(1);
    }

    public void ShowVideo2()
    {
        VideoStaticData.VideoName = "Video1";
        SceneManager.LoadScene(1);
    }

    public void QuitGame() 
    {
        Application.Quit();
    }

    public void Settings()
    {
        // SceneManager.LoadScene("settings");
    }
}
