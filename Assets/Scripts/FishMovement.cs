using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    private Vector3 pos;
    private float fishSpeed = 5;
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
        pos = transform.position;

        pos.x += fishSpeed * dir;
        transform.position = pos;

        if (pos.x > 650 | pos.x < -400)
        {
            Destroy(gameObject);
        }
    }
}
