using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallProblem4 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal") *moveSpeed;
        movement.y = Input.GetAxisRaw("Vertical") * moveSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(movement.x,movement.y);
    }
}
