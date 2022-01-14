using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}