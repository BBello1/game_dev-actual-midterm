using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class DropLocation : MonoBehaviour
{

   int items = 0;

    void Start()
    {
     
    }
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        items += 1;

        if (items == 3)
        {
            SceneManager.LoadScene("End_Scene", LoadSceneMode.Single);
        }
    }
}
