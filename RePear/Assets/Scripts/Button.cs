using Unity;
using UnityEngine;

    public class Button : UnityEngine.MonoBehaviour, IInteractable
    {
        public GameEvent interactionPossible, interactionNotPossible, buttonPressed;
        
        public void Use()
        {
            buttonPressed.Raise();
            print("Use was raised");
        }

        public void DisplayPrompt()
        {
            interactionPossible.Raise();
        }

        public void RemovePrompt()
        {
            interactionNotPossible.Raise();
        }
    }
