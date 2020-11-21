using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private VideoPlayer vidplayer;

    [SerializeField]
    VideoClip[] vids;

    // Start is called before the first frame update
    void Start()
    {
        vidplayer = GetComponent<VideoPlayer>();
    }
    public void Play()
    {
        vidplayer.Play();
    }
    public void Pause()
    {
        vidplayer.Pause();
    }
    public void Stop()
    {
        vidplayer.Stop();
    }

    public void LivingSpace()
    {
        VidChange(0);
    }

    public void Cube()
    {
        VidChange(1);
    }

    public void Cantina()
    {
        VidChange(2);
    }

    public void Mezzanine()
    {
        VidChange(3);
    }

    public void VidChange(int vid_id)
    {
        vidplayer.source = VideoSource.VideoClip;
        vidplayer.clip = vids[vid_id];
        vidplayer.Prepare();
        vidplayer.prepareCompleted += VideoPlayer_prep;
    }

    private void VideoPlayer_prep(VideoPlayer source)
    {
        Play();
    }
}
