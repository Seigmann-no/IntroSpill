using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

public class SpeedZone : MonoBehaviour
{
    public float boostForce = 0.5f;
    
    private void OnTriggerStay(Collider other)
    {
       Rigidbody rigidbody = other.attachedRigidbody;
        if (rigidbody != null)
        {
            rigidbody.linearVelocity *= boostForce;
        }
    }
    }