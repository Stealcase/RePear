using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCharacterGravity : MonoBehaviour
{
    public float force;
    private Rigidbody rb;
    private float floatDelay = 40f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public IEnumerator sendFlying()
    {
        yield return new WaitForSeconds(floatDelay);
        rb.AddRelativeForce(0, force,0);
    }

    public void DisablePlayerGrav()
    {
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.None;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        StartCoroutine(sendFlying());
    }
}
