using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject box;
    public GameObject triangle;
    private void Start()
    {
        Invoke("Spawn", 1f);
        Invoke("SpawnTri",1f);
    }

    public void Spawn()
    {
        float posX, posY;
        Vector2 pos;

        int numberToSpawn = Random.Range(4, 5);

        for(int i = 0; i< numberToSpawn; i++)
        {
            posX = Random.Range(-3, 3);
            posY = Random.Range(-3, 3);
            pos = new Vector2(posX, posY);

            Instantiate(box, pos, box.transform.rotation);
        }
    }
    public void SpawnTri()
    {
        float posX, posY;
        Vector2 pos;

        int numberToSpawn = Random.Range(1, 3);

        for(int i = 0; i< numberToSpawn; i++)
        {
            posX = Random.Range(-3, 3);
            posY = Random.Range(-3, 3);
            pos = new Vector2(posX, posY);

            Instantiate(triangle, pos, triangle.transform.rotation);
        }
    }
}

