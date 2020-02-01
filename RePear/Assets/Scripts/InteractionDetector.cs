using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractionDetector : MonoBehaviour
{
    private Collider _collider;
    List<Collider> targets;
    private List<IInteractable> _interactables;
    
    // Start is called before the first frame update
    void Start()
    {
        _interactables = new List<IInteractable>();
        targets =  new List<Collider>();
        if (_collider = null)
        {
            _collider = GetComponent<Collider>();
        }
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            print("Got button press");
            if (_interactables.Any())
            {
                print("Trying to use the button");
                _interactables[_interactables.Count-1].Use();
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            if (other.gameObject.GetComponent<IInteractable>() != null)
            {
                _interactables.Add(other.GetComponent<IInteractable>());
                _interactables[_interactables.Count-1].DisplayPrompt();
                print(_interactables.Count);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactable"))
            print("Exit area of interaction");
            if (other.gameObject.GetComponent<IInteractable>() != null)
            {
                var interact = other.GetComponent<IInteractable>();
                if (_interactables.Any())
                {
                    interact.RemovePrompt();
                    _interactables.Remove(interact);
                    print(_interactables.Count);
                }
                
            }
    }
}
