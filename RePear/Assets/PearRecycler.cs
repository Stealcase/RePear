using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearRecycler : MonoBehaviour
{
    public GameEvent pearRecycled;
    public GameObjectList pears;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Pear"))
        {
            pears.objects.Remove(other.gameObject);
            Destroy(other.gameObject);
            pearRecycled.Raise();
            
        }
    }
}
