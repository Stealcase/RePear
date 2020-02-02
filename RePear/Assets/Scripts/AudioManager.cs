    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Audio;
    using System;


    public  class AudioManager : MonoBehaviour
    {
        public List<Sound> sounds;
       [Tooltip("THIS MUST HAVE SAME NUMBER OF ITEMS AS SOUND LIST!!!")]
       public List<GameEvent> gameEvents;
       public string compTag;
       public int soundNumber;
        void awake()
        {
            int i = 0;
            foreach (Sound s in sounds)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                // s.sndListener = gameObject.AddComponent<SoundEventListener>();
                // s.sndListener.sndName = s.soundName;
                // s.sndListener.Event = gameEvents[i];
                // s.sndListener.RegisterListener();
                i++;
            }
        }



        public void PlaySound(string soundName)
        {
            print("finding sound");
            Sound s = sounds.Find(sound => sound.soundName == soundName);
            if (s == null)
            {
                print("didn't find the audio with the name; " + soundName);
                return;
            }
            print("sound " + soundName + "was played" );
            s.source.Play();
        }

        public void PlayVoice()
        {
            sounds[soundNumber].source.Play();
            print("sound was played" );
        }
    }
