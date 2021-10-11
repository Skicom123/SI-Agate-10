using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallProblem7 : MonoBehaviour
{
    public Text scoreText;
    private int score;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Box")
        {
            score++;
            Destroy(collision.gameObject);
            scoreText.text = "Score : " + score;
        }
    }
}
