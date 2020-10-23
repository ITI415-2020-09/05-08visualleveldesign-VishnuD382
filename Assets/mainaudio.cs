using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class mainaudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip MainOfficeNoise;

    public AudioSource audioOffice;

    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot auxInSnapshot;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainOffice"))
        {
            
            idleSnapshot.TransitionTo(0.5f);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainOffice"))
        {
            auxInSnapshot.TransitionTo(0.5f);

        }
    }



}
