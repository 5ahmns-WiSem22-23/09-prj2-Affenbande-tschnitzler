using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClip firstSound;
    public AudioClip secondSound;
    private AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        audioSource.loop = false;
        audioSource.clip = firstSound;
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {

            audioSource.clip = secondSound;
            audioSource.Play();
            audioSource.loop = true;
        }
    }
}
