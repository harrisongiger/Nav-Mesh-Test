using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{

    public Material Red;
    public Material Green;
    public Material Blue;
    private float type;
    public Transform home;
    public Transform home2;
    public Transform home3;
    NavMeshAgent _navMeshAgent;
    public GameObject agent;

    void Start()
    {

        agent = gameObject;

        type = Mathf.Floor(Random.Range(0, 3));

        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        SetDestination();
    }

    private void SetDestination()
    {
        if(home != null && home2 !=null && home3 != null) 
        {
            if (type == 0){
                agent.GetComponent<MeshRenderer>().material = Red;
                _navMeshAgent.SetDestination(home.position);
            } else if (type == 1) {
                agent.GetComponent<MeshRenderer>().material = Green;
                _navMeshAgent.SetDestination(home2.position);
            } else if (type == 2) {
                agent.GetComponent<MeshRenderer>().material = Blue;
                _navMeshAgent.SetDestination(home3.position);
            }

            
        }
    }

}
