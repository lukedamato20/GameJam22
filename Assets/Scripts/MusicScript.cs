using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource myAudioSource;
    float musicVolume = 1f;

    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        myAudioSource.volume = musicVolume;
    }

    public void Volume(float volume)
    {
        musicVolume = volume;
    }

}