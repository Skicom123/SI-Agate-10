using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallProblem5 : MonoBehaviour
{
    Vector2 clickArea;
    public float speed = 12f;

    bool moving;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickArea = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if(moving && (Vector2)transform.position != clickArea)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, clickArea, step);
        }
        else
        {
            moving = false;
        }
    }
}
