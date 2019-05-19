using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneeMovement : MonoBehaviour
{
    public float speed = 5;  // Public for easy debugging.
    public float point = 100;
    private int dir;

    void Start()
    {
        string parentName = transform.parent.name;

        if (parentName == "LeftSpawn")
            dir = 1;
        else
            dir = -1;

        AssignPoint();
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

    void AssignPoint()
    {
        if (name == "1(Clone)")
            point = 100;
        else if (name == "2(Clone)")
            point = 150;
        else if (name == "FastHook(Clone)")
            point = 50;
        else if (name == "ScoreBoost(Clone)")
            point = 50;
    }
}
