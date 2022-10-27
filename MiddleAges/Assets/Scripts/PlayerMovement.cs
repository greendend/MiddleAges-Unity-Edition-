using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    public Vector2 mousePos;
    public Vector2 lookDirRight;

    void Start()
    {
        if (hasAuthority)
        {
            cam = Camera.main;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hasAuthority)
        {
            
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            
            lookDirRight = rb.transform.right;
        }
    }

    private void FixedUpdate()
    {
        if (hasAuthority)
        {
            Vector2 lookDir = mousePos - rb.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
            rb.rotation = angle;

            lookDir.Normalize();
            lookDirRight.Normalize();

            if (Input.GetKey(KeyCode.W))
            {
                rb.MovePosition(rb.position + lookDir * moveSpeed * Time.fixedDeltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.MovePosition(rb.position - lookDir * moveSpeed * Time.fixedDeltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.MovePosition(rb.position - lookDirRight * moveSpeed * Time.fixedDeltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.MovePosition(rb.position + lookDirRight * moveSpeed * Time.fixedDeltaTime);
            }
        }
    }
}
