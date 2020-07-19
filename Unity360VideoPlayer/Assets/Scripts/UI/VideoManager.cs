using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(VideoPlayer))]
public class VideoManager : MonoBehaviour
{
    private VideoPlayer _videoPlayer;
    private bool _isTouching = false;
    private bool _isPaused = false;

    [SerializeField]
    private GameObject _canvas;

    // Start is called before the first frame update
    void Start()
    {
        _videoPlayer = GetComponent<VideoPlayer>();

        _videoPlayer.clip = Resources.Load<VideoClip>("videos/" + VideoStaticData.VideoName);
        _videoPlayer.Prepare();
        _videoPlayer.prepareCompleted += VideoPlayer_prepareComplete;
    }

    private void VideoPlayer_prepareComplete(VideoPlayer source)
    {
        Play();
    }



    // Update is called once per frame
    void Update()
    {
        //android
        if(Input.touchCount > 0  && !_isTouching)
        {
                Pause();
                _isTouching = true;
        }
        else 
        {
            _isTouching = false;
        }


        //pc
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!_isPaused)
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
        _videoPlayer.Play();
        _isPaused = false;
        _canvas.SetActive(false);
    }

    public void Pause() 
    {
        _videoPlayer.Pause();
        _isPaused = true;
        _canvas.SetActive(true);
    }

    public void Stop() 
    {
        _videoPlayer.Stop();
        SceneManager.LoadScene(0);
    }   
}
