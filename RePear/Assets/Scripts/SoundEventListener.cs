using UnityEngine;
using Unity;

public class SoundEventListener : MonoBehaviour, IEventListener 
    {
        public GameEvent Event;
        public string sndName;
        private AudioManager _audioManager;
        

        public void Start()
        {
            Event.RegisterListener(this);
            _audioManager = GetComponent<AudioManager>();
        }
        
        public void OnEnable()
        {
            Event.RegisterListener(this);
        }

        public void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            _audioManager.PlaySound(sndName);
        }

        public void RegisterListener()
        {
                Event.RegisterListener(this);
        }
    }
