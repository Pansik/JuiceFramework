using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioTrigger : MonoBehaviour
{
    public float maxPitch;
    public float minPitch;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Shooting.EventBulletShooted += PlaySound;
    }

    private void PlaySound()
    {
        RandomizePitch();
        audioSource.Play();
    }

    private void RandomizePitch()
    {
        audioSource.pitch = Random.Range(minPitch, maxPitch);
    }
}
