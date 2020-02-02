using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
    public class Sound
    {
        [FormerlySerializedAs("name")] public string soundName;
        public AudioClip clip;
        [Range(0f,1f)]
        public float volume = 1f;
        [Range(.1f,3f)]
        public float pitch = 0.1f;

        public AudioSource source;
        [HideInInspector] public SoundEventListener sndListener;
    }
