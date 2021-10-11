using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BallProblem9 : MonoBehaviour
{
    public GameObject box;
    public GameObject Triangle;
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
            Invoke("Respawn", 3f);
        }

        if(collision.tag == "Triangle")
        {
            SceneManager.LoadScene("Problem9");
        }
    }
    public void Respawn()
    {
        float posX, posY;
        Vector2 pos;

        for (int i = 0; i < 1; i++)
        {
            posX = Random.Range(3, -3);
            posY = Random.Range(3, -3);
            pos = new Vector2(posX, posY);

            Instantiate(box, pos, box.transform.rotation);
        }
    }
}
