using System;
using UnityEngine;
using UnityEngine.Rendering;

public class TeleportButtonScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            // Teleport the player to a new position
            other.enabled = false;
            other.transform.position = new Vector3(0, 0, 0);
            other.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Get Teleported idiot");
        }
    }
}