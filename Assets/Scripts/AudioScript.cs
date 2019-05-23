using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private AudioSource musicSource;
    private AudioSource sourceAudio;

    private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        musicSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        musicSource.volume = musicVolume;
    }

    public void SetMusicVolume(float vol) {

        musicVolume = vol;
    }
}
