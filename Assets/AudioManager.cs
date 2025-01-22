using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;

    public AudioClip jump;
    public AudioClip death;


    public void PlasySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
