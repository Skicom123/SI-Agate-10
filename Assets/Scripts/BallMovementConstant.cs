using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementConstant : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (5f,0f);
    }
}
