using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneeMovement : MonoBehaviour
{
    public float speed = 5;  // Public for easy debugging.
    public float point = 0;
    public float coin = 0;

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

        if (dir == 1 && transform.localPosition.x > 2100)
        {
            Destroy(gameObject);
        }
        if (dir == -1 && transform.localPosition.x < -2100)
        {
            Destroy(gameObject);
        }
    }

    void AssignPointSpeed()
    {
        if (name == "1(Clone)")
        {
            point = 10;
            speed = 4;
            coin = 4;
        }
        else if (name == "2(Clone)")
        {
            point = 15;
            speed = 7;
            coin = 7;
        }
        else if (name == "3(Clone)")
        {
            point = 13;
            speed = 7;
            coin = 7;
        }
        else if (name == "4(Clone)")
        {
            point = 10;
            speed = 3;
            coin = 3;
        }
        else if (name == "5(Clone)")
        {
            point = 11;
            speed = 5;
            coin = 5;
        }
        else if (name == "6(Clone)")
        {
            point = 12;
            speed = 6;
            coin = 6;
        }
        else if (name == "7(Clone)")
        {
            point = 15;
            speed = 7;
            coin = 7;
        }
        else if (name == "8(Clone)")
        {
            point = 10;
            speed = 5;
            coin = 5;
        }
        else if (name == "FastHook(Clone)")
        {
            point = 10;
            speed = 5;
            coin = 5;
        }
        else if (name == "ScoreBoost(Clone)")
        {
            point = 10;
            speed = 5;
            coin = 5;
        }
        else if (name == "SpeedUp(Clone)")
        {
            point = 10;
            speed = 5;
            coin = 5;
        }
        else if (name == "ExtraHealth(Clone)")
        {
            point = 10;
            speed = 5;
            coin = 5;
        }
        else if (name == "IceBoost(Clone)")
        {
            point = 10;
            speed = 5;
            coin = 5;
        }
        else if (name == "d1(Clone)")
        {
            point = 0;
            speed = 5;
        }
        else if (name == "d2(Clone)")
        {
            point = 0;
            speed = 5;
        }
        else if (name == "d3(Clone)")
        {
            point = 0;
            speed = (float)4.5;
        }
        else if (name == "d4(Clone)")
        {
            point = 0;
            speed = 6;
        }
        else if (name == "d5(Clone)")
        {
            point = 0;
            speed = 7;
        }
        else if (name == "d6(Clone)")
        {
            point = 0;
            speed = 5;
        }
        else if (name == "d7(Clone)")
        {
            point = 0;
            speed = 5;
        }
        else if (name == "d8(Clone)")
        {
            point = 0;
            speed = 5;
        }
        else if (name == "d9(Clone)")
        {
            point = 0;
            speed = 8;
        }
        else if (name == "d10(Clone)")
        {
            point = 0;
            speed = 5;
        }
        else if(tag == "Obstacle")
        {
            point = 0;
            speed = 5;
        }
    }
}
