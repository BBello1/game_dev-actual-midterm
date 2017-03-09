using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupTrigger : MonoBehaviour
{
    public Text currentItemText;
    Collider thingHolding;
    void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButton(0) == true)
        {
            Debug.Log("Click");
            other.transform.SetParent(transform);
            thingHolding = other;
            currentItemText.text = thingHolding.GetComponent<Item>().itemText;
            thingHolding.transform.SetParent(transform);
            thingHolding.attachedRigidbody.isKinematic = true;
        }

       
    }

    void Update()
    {
        if (Input.GetMouseButton(0) == false)
        {
            thingHolding.attachedRigidbody.isKinematic = false;
            currentItemText.text = "";
        }

        if (Input.GetMouseButton(0) == false && thingHolding != null)
        {
            thingHolding.transform.SetParent(null); 
            thingHolding = null;
        }
    }

    
}
