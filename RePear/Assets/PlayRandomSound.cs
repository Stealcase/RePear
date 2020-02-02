using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Random = UnityEngine.Random;

public class PlayRandomSound : MonoBehaviour
{
    private AudioSource _source;
    public List<AudioClip> sounds;
    private int maxSize;
    public float requiredNoiseVelocity = 8f;

    private void Start()
    {
         maxSize = sounds.Count - 1;
        _source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.relativeVelocity.magnitude > requiredNoiseVelocity)
        {
            int rnd = Random.Range(0, maxSize);
            _source.pitch = Random.Range(0.1f, 3f);
            _source.PlayOneShot(sounds[rnd]);
        }

    }
}
