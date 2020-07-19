using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlay : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;
    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();

        videoPlayer.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
         var vp = GetComponent<UnityEngine.Video.VideoPlayer>();

         if (Input.GetButtonDown("OculusB2") || Input.GetButtonDown("OculusB4") || Input.GetKeyDown("b"))
        {
            vp.Play();
        }
        vp.loopPointReached += LoadScene;
    }
    void  LoadScene(VideoPlayer vp){
        SceneManager.LoadScene("Bosque");
    }
}
