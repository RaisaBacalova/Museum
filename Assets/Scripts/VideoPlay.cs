using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour {

    /* public VideoPlayer video;

     public void OnClickPlay()
     {
         Debug.Log("'Play' was called");

         video.Play();

     }*/

    public GameObject quad;
    private VideoPlayer video;

    void Awake()
    {
        video = quad.GetComponent<VideoPlayer>();
    }

    public void OnClickPlay()
    {
        Debug.Log("'Play' was called");
        
        video.Play();
    }
}
