using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGravity1 : MonoBehaviour {

    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.useGravity = false;
        }

    }
}