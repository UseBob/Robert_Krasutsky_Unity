using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class triggerAudio : MonoBehaviour
{
    public AudioMixerSnapshot inside;
    public AudioMixerSnapshot outside;
    public AudioSource insideAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inside.TransitionTo(0.5f);
            insideAudio.volume = 0.1f;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            outside.TransitionTo(1.5f);
        }
    }
}
