using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Button : MonoBehaviour
{
    //public GameObject button;
    //public UnityEvent onPress;
    //public UnityEvent onRelease;
    //GameObject presser;
    //bool isPressed;
    //void Start()
    //{
    //    isPressed = false;
    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(!isPressed)
    //    {
    //        button.transform.localPosition = new Vector3(0,0.003f,0);
    //        presser = other.gameObject;
    //        onPress.Invoke();
    //        isPressed = true;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if(other == presser)
    //    {
    //        button.transform.localPosition = new Vector3(0,0.015f,0);
    //        onRelease.Invoke();
    //        isPressed = false;
    //    }
    //}
    public float deadTime = 1.0f;
    private bool deadTimeActive = false;
    public UnityEvent onPressed, onReleased;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Button")
        {
            onPressed?.Invoke();
            Debug.Log("Button Pressed");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Button" && !deadTimeActive)
        {
            onPressed?.Invoke();
            Debug.Log("Button Released");
            StartCoroutine(WaitForDeadTime());
        }
    }
    IEnumerator WaitForDeadTime()
    {
        deadTimeActive = true;
        yield return new WaitForSeconds(deadTime);
        deadTimeActive = false;
    }
}
