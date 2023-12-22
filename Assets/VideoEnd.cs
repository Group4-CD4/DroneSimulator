using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoEnd : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject gameObject;
    public GameObject finish;
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        if ( (float)videoPlayer.time+ 0.3 >= (float)videoPlayer.length)
        {
            gameObject.SetActive(false);
            finish.SetActive(true);
        }
    }
}
