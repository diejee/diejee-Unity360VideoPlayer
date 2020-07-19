using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void showVideos() {
        SceneManager.LoadScene("videos");
    }

    public void quitGame() {
        Application.Quit();
    }

    public void settings(){
        SceneManager.LoadScene("settings");
    }
}
