﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioClip buttonClickFX;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
    }

    private void Start()
    {
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        Debug.Log("playing " + clip.name);

        sfxSource.PlayOneShot(clip);
    }

    public void PlayButtonClick()
    {
        Debug.Log("playing UI Click");
        sfxSource.PlayOneShot(buttonClickFX);

    }
}