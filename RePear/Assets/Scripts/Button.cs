using Unity;
using UnityEngine;

    public class Button : UnityEngine.MonoBehaviour, IInteractable
    {
        public GameEvent interactionPossible, interactionNotPossible, buttonPressed, buttonDenied;
        public bool isButtonCooldown = false;
        public void Use()
        {
            if(!isButtonCooldown)
            {
                buttonPressed.Raise();
            }
            else
            {
                buttonDenied.Raise();
            }
            
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
