using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    Rigidbody[] rigidBodies;
    Animator animator;
    private void Start()
    {
        rigidBodies = GetComponentsInChildren<Rigidbody>();
        animator = GetComponentInParent<Animator>();
        DeactivateRagdoll();
    }
    public void DeactivateRagdoll()
    {
        foreach (var rigidBody in rigidBodies)
            rigidBody.isKinematic = true;
        animator.enabled = true;
    }
    public void ActivateRagdoll()
    {
        foreach (var rigidBody in rigidBodies)
            rigidBody.isKinematic = false;
        animator.enabled = false;
    }
    public void ApplyForce(Vector3 force)
    {
        var rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(force,ForceMode.VelocityChange);
    }
}
