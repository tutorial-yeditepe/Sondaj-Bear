using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneeMovement : MonoBehaviour
{
    public float speed = 5;  // Public for easy debugging.
    public float point = 100;
    public float coin = 5;

    private int dir;

    void Start()
    {
        string parentName = transform.parent.name;

        if (parentName == "LeftSpawn")
            dir = 1;
        else
            dir = -1;

        AssignPointSpeed();
    }

    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += speed * dir;
        transform.position = pos;

        if (pos.x > 650 | pos.x < -400)
        {
            Destroy(gameObject);
        }
    }

    void AssignPointSpeed()
    {
        if (name == "1(Clone)")
        {
            point = 5;
            speed = 5;
        }
        else if (name == "2(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "3(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "4(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "5(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "6(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "7(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "8(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "FastHook(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "ScoreBoost(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if (name == "SpeedUp(Clone)")
        {
            point = 10;
            speed = 5;
        }
        else if(tag == "Obstacle")
        {
            point = 0;
            speed = 5;
        }
    }
}
