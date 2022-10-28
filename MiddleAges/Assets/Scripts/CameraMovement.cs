using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    void Update()
    {
        if (!this.transform.parent.GetComponent<PlayerMovement>().isLocalPlayer)
        {
            gameObject.GetComponent<Camera>().enabled = false;
            gameObject.GetComponent<AudioListener>().enabled = false;            
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().transform.position = this.transform.parent.GetComponent<PlayerMovement>().transform.position;
        }
    }
}
