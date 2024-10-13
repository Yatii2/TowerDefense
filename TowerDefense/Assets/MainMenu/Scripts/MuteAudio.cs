using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuteAudio : MonoBehaviour
{
    [SerializeField] AudioSource bgmusic;

    public bool IsMuted { get; private set; } = false;

    public static MuteAudio instance;
    
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    public void MuteToggle(bool muted)
    {
        IsMuted = muted;
        if (bgmusic != null)
        {
            bgmusic.volume = muted ? 0 : 0.4f;
        }
        else
        {
            Debug.LogWarning("audiosource missing on" + gameObject.name);
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainGame")
        {
            if (!IsMuted && bgmusic != null)
            {
                if (!bgmusic.isPlaying)
                {
                    bgmusic.Play();
                }
            }
        }
    }
}