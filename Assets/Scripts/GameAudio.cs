using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameAudio
{
    [SerializeField]
    AudioClip background;
    [SerializeField]
    AudioClip battle;

    AudioSource aud;

    public AudioSource Aud { get => aud; set => aud = value; }

    public void PlayAudio(AudioClip audioClip)
    {
        if(!ClipEqual(audioClip))
        {
            aud.clip = audioClip;
            aud.Play();
        }
    }

    public void PlayBGMusic()
    {
        PlayAudio(background);
    }

     public void PlayBattleMusic()
    {
        PlayAudio(battle);
    }

    bool ClipEqual(AudioClip clip)
    {
        return clip == aud.clip;
    }
}
