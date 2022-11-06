using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject[] points;
    bool dragged;
    private Vector3 startPosition;
    private float duration = 10f;
    private float elapsed;
    private float percentageComplete;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        dragged = false;
        elapsed += Time.deltaTime;
        startPosition = transform.position;
        percentageComplete = elapsed / duration;
    }

    // Update is called once per frame
    void Update()
    {
        if(dragged)
        {
            FollowPath();
        }
    }
    public void SwapControls()
    {
        dragged = !dragged;
    }
    void FollowPath()
    {
        while (i != points.Length-1)
        {
            transform.position = Vector3.Lerp(startPosition, points[i].transform.position, percentageComplete);
            if(transform.position == points[i].transform.position)
            {
                i++;
            }
        }
        i = 0;
        SwapControls();
    }
}
