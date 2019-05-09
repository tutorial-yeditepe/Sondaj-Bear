using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] [Range(1.0f, 10.0f)] public float moveSpeed = 5.0f;
    private float width = Screen.width;
    private float height = Screen.height;
    private float charWidth;
    private Vector2 pos;
    private Vector2 bottomCorner;
    private Vector2 topCorner;
    private float center;

    private void Start()
    {
        pos = this.transform.position;
        charWidth = this.GetComponent<SpriteRenderer>().bounds.size.x;
        center = width / 2;
        float camDistance = Vector2.Distance(transform.position, Camera.main.transform.position);
        bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        pos = this.transform.position;
        if (Input.GetMouseButton(0) && Input.mousePosition.y > ((height*60)/100))
        { 
            if (pos.x > bottomCorner.x + charWidth/2)
                if (Input.GetMouseButton(0) && Input.mousePosition.x < center - 0.5)
                {
                    pos.x = pos.x - moveSpeed;
                    this.transform.position = pos;
                }
            if (pos.x < topCorner.x - charWidth/2)
                if (Input.GetMouseButton(0) && Input.mousePosition.x > center + 0.5)
                {
                    pos.x = pos.x + moveSpeed;
                    this.transform.position = pos;
                }
        }
    }
}
