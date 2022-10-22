using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        rb.position = GameObject.FindGameObjectWithTag("Player_01").transform.position;
    }
}
