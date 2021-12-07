using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{

    private float type;
    public Transform home;
    public Transform home2;
    public Transform home3;
    public Transform home4;
    NavMeshAgent _navMeshAgent;
    public GameObject agent;
    public Material US;
    public Material France;
    public Material Germany;
    public Material Japan;
    public Material Other;

    void Start()
    {

        agent = gameObject;

        type = Mathf.Floor(Random.Range(0, 5));

        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        SetDestination();
    }

    private void SetDestination()
    {
        if(home != null && home2 !=null && home3 != null) 
        {
            if (type == 0){
                _navMeshAgent.SetDestination(home.position);
            } else if (type == 1) {
                _navMeshAgent.SetDestination(home2.position);
            } else if (type == 2) {
                _navMeshAgent.SetDestination(home3.position);
            } else if (type == 3) {
                _navMeshAgent.SetDestination(home4.position);
            } else if (type == 4) {
                _navMeshAgent.SetDestination(home4.position);
            }

            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
