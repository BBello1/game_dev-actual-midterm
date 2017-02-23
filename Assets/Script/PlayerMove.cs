using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformVector(new Vector3(0f, 0f, .1f));
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.localEulerAngles += new Vector3(0f, -90f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localEulerAngles += new Vector3(0f, 90f * Time.deltaTime, 0f);
        }

    }
}
