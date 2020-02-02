using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
    public class SoundStacker : UnityEngine.MonoBehaviour
    {
        public List<AudioClip> clips;

        public AudioSource source;
        private int number = 0;

        public void StackAudioAndPlay()
        {
            if (number > (clips.Count - 1))
            {
                number = 0;
                return;
            }

            if (source.isPlaying)
            {
                number++;
                return;
            }
            source.PlayOneShot(clips[number]);
            number++;
            
        }
    }
