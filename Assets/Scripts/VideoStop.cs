using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoStop : MonoBehaviour {

    public GameObject quad;
    private VideoPlayer video;

    void Awake()
    {
        video = quad.GetComponent<VideoPlayer>();
    }

    public void OnClicStop()
    {
        Debug.Log("'Stop' was called");

        video.Stop();
    }
}
