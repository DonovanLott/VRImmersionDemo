using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject[] points;
    bool dragged;
    private Vector3 startPosition;
    public float duration = 5f;
    private float elapsed;
    private float percentageComplete = 0;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        dragged = false;
        //elapsed += Time.deltaTime;
        startPosition = transform.position;
        //percentageComplete = elapsed / duration;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (dragged == true)
        {
            elapsed += Time.deltaTime;
            percentageComplete = elapsed / duration;
            FollowPath();
        }
    }
    public void SwapControls()
    {
        dragged = true;
    }
    void FollowPath()
    {
        if (i <= points.Length - 1)
        {
            transform.position = Vector3.Lerp(startPosition, points[i].transform.position, percentageComplete);
            if (transform.position == points[i].transform.position)
            {
                startPosition = points[i].transform.position;
                elapsed = 0;
                i++;
            }
        }
        else
        {
            i = 0;
            elapsed = 0;
            startPosition = transform.position;
            dragged = false;
        }
    }
}
