using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void showVideo1() {
        VideoStaticData.VideoName = "Video2";
        SceneManager.LoadScene("360Playerv1");
    }

    public void showVideo2(){
        VideoStaticData.VideoName = "Video1";
        SceneManager.LoadScene("360Playerv1");
    }

    public void quitGame() {
        Application.Quit();
    }

    public void settings(){
        SceneManager.LoadScene("settings");
    }
}
