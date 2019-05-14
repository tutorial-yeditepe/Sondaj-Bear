using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    private bool flag = false;
    private Vector2 endPoint;
    public float duration = 1f;
    public float speed = 4f;
    private Vector2 startPoint;
    RaycastHit2D hit;
    Vector2 ray;
    private float timeStartedLerping;
    bool hasArrived = true;

    void Start()
    {
        startPoint = gameObject.transform.position;
    }

    void Update()
    {
        ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(ray, Vector2.zero);

        //check if the screen is touched / clicked   
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || (Input.GetMouseButtonDown(0)))
        {
            if (hasArrived)
                //Check if the ray hits any collider
                if (hit.collider != null)
                {
                    Debug.Log("hit");
                    //set a flag to indicate to move the gameobject
                    flag = true;
                    timeStartedLerping = Time.time;
                    //save the click / tap position
                    endPoint = hit.point;
                    Debug.Log(endPoint);
                }
        }
        Debug.Log(hasArrived);
        //Debug.Log(flag);

        if (flag)
        {
            hasArrived = false;
            float timeSinceStarted = Time.time - timeStartedLerping;
            float percentageComplete = timeSinceStarted / duration;
            //Debug.Log(percentageComplete + "if");

            gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, endPoint, percentageComplete * speed);

            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || (Input.GetMouseButtonUp(0)))
            {
                flag = false;
                timeStartedLerping = Time.time;
            }
        }
        else
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            float percentageComplete = timeSinceStarted / duration;
            //Debug.Log(percentageComplete+"else");

            gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, startPoint, percentageComplete * speed);

            if (Mathf.Approximately(Mathf.Round(gameObject.transform.position.x),Mathf.Round(startPoint.x)) && Mathf.Approximately(Mathf.Round(gameObject.transform.position.y), Mathf.Round(startPoint.y)))
                hasArrived = true;
        }
    }
}

