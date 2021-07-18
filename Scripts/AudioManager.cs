using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer music;
    public AudioSource BGmusic;
    public static AudioManager instance;

    [Range(-80,10)]
    public float MasterVol;

    public Slider MasterS;

    void Start()
    {
        MasterS.value = MasterVol;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Update()
    {
        MasterVolume();
    }
    public void MasterVolume()
    {
        music.SetFloat("MasterVolume", MasterS.value);
    }

    public void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }
}
