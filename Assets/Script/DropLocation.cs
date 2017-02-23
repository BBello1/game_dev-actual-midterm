using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropLocation : MonoBehaviour
{

   

    void Start()
    {
     
    }
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
