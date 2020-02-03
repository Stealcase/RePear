// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu]
    public class GameEvent : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        
        private readonly List<IEventListener> eventListeners = 
            new List<IEventListener>();

        public bool disabled;

        public void Raise()
        {
            if(disabled)
            {
                return;
            }
            else
            {
                for(int i = eventListeners.Count -1; i >= 0; i--)
                    eventListeners[i].OnEventRaised();
            }
            
        }

        public void RegisterListener(IEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(IEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
