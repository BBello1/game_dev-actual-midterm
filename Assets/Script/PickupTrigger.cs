using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : MonoBehaviour
{

    Collider thingHolding;
    void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButton(0) == true)
        {
            Debug.Log("Click");
            other.transform.SetParent(transform);
            thingHolding = other; 
            thingHolding.transform.SetParent(transform); 
        }
    }

  
    void Update()
    {
        if (Input.GetMouseButton(0) == false && thingHolding != null)
        {
            thingHolding.transform.SetParent(null); 
            thingHolding = null; 
        }

    }
}
