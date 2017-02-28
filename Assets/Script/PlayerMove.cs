using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    float upDownLook = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformVector(new Vector3(0f, 0f, .15f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.TransformVector(new Vector3(0f, 0f, .15f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.TransformVector(new Vector3(.1f, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformVector(new Vector3(.1f, 0f, 0f));
        }



        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * 100f; 
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * 75f; 
        
        transform.Rotate(0f, mouseX, 0f);

        upDownLook -= mouseY; 
        upDownLook = Mathf.Clamp(upDownLook, -80f, 80f); 

        transform.localEulerAngles = new Vector3(upDownLook, transform.localEulerAngles.y, 0f);

        
        if (Input.GetKeyDown(KeyCode.R))
            {
            SceneManager.LoadScene("Midterm", LoadSceneMode.Single);
        }

        }
}
