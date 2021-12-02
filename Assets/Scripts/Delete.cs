using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Agent"))
        {
            Destroy(other.gameObject);
            Debug.Log("COCK");
        }
    }
}