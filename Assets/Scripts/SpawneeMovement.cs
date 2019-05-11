using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneeMovement : MonoBehaviour
{
    public float speed = 5;  // Public for easy debugging.
    private int dir;

    void Start()
    {
        string parentName = transform.parent.name;

        if (parentName == "LeftSpawn")
            dir = 1;
        else
            dir = -1;
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
}
