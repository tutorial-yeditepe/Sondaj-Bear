using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour
{
    public AudioClip buttonSound;

    private Button button { get {return GetComponent<Button>();} }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    void Start() {

        gameObject.AddComponent<AudioSource>();
        source.clip = buttonSound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());

    }

    void PlaySound() {

        source.PlayOneShot(buttonSound);
    }
}
