using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    public Vector2 mousePos;
    public Vector2 posRight;

    // Update is called once per frame
    void Update()
    {        
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        posRight = rb.transform.right;
    }

    private void FixedUpdate()
    {        
        Vector2 lookDir = mousePos - rb.position;
        Vector2 lookDirRight = posRight;
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

        //else if (Input.GetKey(KeyCode.A))
        //{
        //lookDir.x = -(lookDir.y) * Mathf.Sin(90f * Mathf.Rad2Deg) + (lookDir.x) * Mathf.Cos(90f * Mathf.Rad2Deg);
        //lookDir.y = (lookDir.y) * Mathf.Cos(90f * Mathf.Rad2Deg) + (lookDir.x) * Mathf.Sin(90f * Mathf.Rad2Deg);
        //rb.MovePosition(rb.position - lookDir * moveSpeed * Time.fixedDeltaTime);
        //}

    }
}