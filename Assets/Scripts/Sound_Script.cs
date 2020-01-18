using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Sound_Script : MonoBehaviour {

    VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }


	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            if (!videoPlayer.GetDirectAudioMute(0))
            {
                Debug.Log("music is on");
                videoPlayer.SetDirectAudioMute(0, true);
            }
            else if(videoPlayer.GetDirectAudioMute(0))
                videoPlayer.SetDirectAudioMute(0, false);
        }
	}
}
