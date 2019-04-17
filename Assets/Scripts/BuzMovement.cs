using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzMovement : MonoBehaviour
{
    [SerializeField] [Range(1.0f, 10.0f)] public float moveSpeed = 5;
    private Vector2 pos;
    private float center;

    private void Start()
    {
        pos = this.transform.position;
        center = pos.x;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        pos = this.transform.position;
        //Touch touch = Input.GetTouch(0);
        if (Input.GetMouseButton(0) && Input.mousePosition.y > 350)
        { 
            if (pos.x > 120.5)
                if (Input.GetMouseButton(0) && Input.mousePosition.x < center - 0.5)
                {
                    pos.x = pos.x - moveSpeed;
                    this.transform.position = pos;
                }
            if (pos.x < 790.5)
                if (Input.GetMouseButton(0) && Input.mousePosition.x > center + 0.5)
                {
                    pos.x = pos.x + moveSpeed;
                    this.transform.position = pos;
                }
        }
    }
}
