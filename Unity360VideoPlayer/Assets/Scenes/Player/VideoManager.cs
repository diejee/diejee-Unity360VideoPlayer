using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{

    private VideoPlayer videoPlayer;

    [SerializeField]
    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.clip = Resources.Load<VideoClip>("videos/" + VideoStaticData.VideoName);
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareComplete;
    }

    private void VideoPlayer_prepareComplete(VideoPlayer source)
    {
        Play();
    }

    private bool isTouching = false;
    private bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        //android
        if(Input.touchCount > 0  && !isTouching)
        {
                Pause();
                isTouching = true;
        }
        else 
        {
            isTouching = false;
        }


        //pc
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!isPaused)
            {
                Pause();
            }
            else
            {
                Play();
            }
        }
    }

    public void Play()
    {
        videoPlayer.Play();
        isPaused = false;
        canvas.SetActive(false);
    }

    public void Pause() 
    {
        videoPlayer.Pause();
        isPaused = true;
        canvas.SetActive(true);
    }

    public void Stop() 
    {
        videoPlayer.Stop();
        SceneManager.LoadScene("menu");
    }   
}
