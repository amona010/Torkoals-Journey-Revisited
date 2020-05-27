using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMovement : MonoBehaviour
{
    Vector2 spawnPos;
    public GameObject enemyBag, enemyBottle, dolphin, gull, rings, fish;
    void Start()
    {
        spawnPos = new Vector2(4, 0);
        InvokeRepeating("ChangePosition", 0, 2);
    }

    void ChangePosition()
    {
        transform.position = spawnPos;

        int type = Random.Range(1, 7);

        spawnPos = new Vector2(4, Random.Range((float)-2.05, (float)2.05));

        if(type == 1)
        {
            Instantiate(enemyBag, spawnPos, Quaternion.identity);
        }
        if (type == 2)
        {
            Instantiate(enemyBottle, spawnPos, Quaternion.identity);
        }
        if (type == 3)
        {
            Instantiate(dolphin, spawnPos, Quaternion.identity);
        }
        if (type == 4)
        {
            Instantiate(gull, spawnPos, Quaternion.identity);
        }

        if (type == 5)
        {
            Instantiate(rings, spawnPos, Quaternion.identity);
        }
        if(type == 6)
        {
            Instantiate(fish, spawnPos, Quaternion.identity);
        }


    }

}
