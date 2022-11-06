using UnityEngine;
using System.Collections;
public class MusicControl : MonoBehaviour
{
    public AudioSource audioObject;
    public bool closeEnough;
    public int colliderCount;

    void Update()
    {
        if (closeEnough == true)
        {
            if (!audioObject.isPlaying)
            {
                audioObject.Play();
            }
        }
        else if (closeEnough == false)
        {
            if (audioObject.isPlaying)
            {
                audioObject.Pause();
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            colliderCount += 1;
            Debug.Log("Player has approached the shrine.");
            UpdateState();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            colliderCount -= 1;
            Debug.Log("Player is leaving the shrine.");
            UpdateState();
        }
    }
    void UpdateState()
    {
        if (colliderCount == 0)
        {
            closeEnough = false;
        }
        else if (colliderCount > 0)
        {
            closeEnough = true;
        }
    }
}