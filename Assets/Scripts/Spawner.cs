using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    public GameObject Agent1;
    public GameObject Agent2;
    public GameObject Agent3;
    public GameObject Agent4;
    public Color Red;
    public Color Blue;
    public Color Green;
    public Color Yellow;
    public Color Grey;
    NavMeshAgent _navMeshAgent;
    private Transform spawnlocation;
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;
    public GameObject Spawn5;
    private GameObject agentsnuts;
    public GameObject home1;
    public GameObject home2;
    public GameObject home3;
    public GameObject home4;
    private float timer;
    public float ajents;
    private string agentcolor;
    public int numb0;
    public int numb1;
    public int numb2;
    public int numb3;
    public int totalnum;

    private void Start()
    {
        
        timer = Time.time + .1f;
    }

    void Update()
    {

        if (timer < Time.time && ajents <= 40)
        {
            ajents++;
            timer = Time.time + .1f;

            var rand1 = Random.Range(0, 100);

            if (rand1 <= 20)
            {
                spawnlocation = Spawn1.gameObject.transform;
            }
            else if (rand1 <= 40)
            {
                spawnlocation = Spawn2.gameObject.transform;
            }
            else if (rand1 <= 60)
            {
                spawnlocation = Spawn3.gameObject.transform;
            }
            else if (rand1 <= 80)
            {
                spawnlocation = Spawn4.gameObject.transform;
            }
            else if (rand1 <= 100)
            {
                spawnlocation = Spawn5.gameObject.transform;
            }

            var rand3 = Random.Range(0, 100);

            if (rand3 <= 10)
            {
                
                agentcolor = "Green";
                var GreenRand = Random.Range(0, 100);

                if (GreenRand <= 32)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home1.transform.position;
                    numb3++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Green);
                }
                else if (GreenRand <= 56)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home2.transform.position;
                    numb2++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Green);
                }
                else if (GreenRand <= 84)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home3.transform.position;
                    numb1++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Green);
                }
                else if (GreenRand <= 100)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home4.transform.position;
                    numb0++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Green);
                }
            }
            else if (rand3 <= 23)
            {
                agentcolor = "Grey";
                var GreyRand = Random.Range(0, 100);

                if (GreyRand <= 40)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home1.transform.position;
                    numb3++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Grey);
                }
                else if (GreyRand <= 60)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home2.transform.position;
                    numb2++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Grey);
                }
                else if (GreyRand <= 76)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home3.transform.position;
                    numb1++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Grey);
                }
                else if (GreyRand <= 100)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home4.transform.position;
                    numb0++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Grey);
                }
            }
            else if (rand3 <= 44)
            {
                agentcolor = "Red";
                var RedRand = Random.Range(0, 100);

                if (RedRand <= 38)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home1.transform.position;
                    numb3++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Red);
                }
                else if (RedRand <= 68)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home2.transform.position;
                    numb2++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Red);
                }
                else if (RedRand <= 87)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home3.transform.position;
                    numb1++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Red);
                }
                else if (RedRand <= 100)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home4.transform.position;
                    numb0++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Red);
                }
            }
            else if (rand3 <= 68)
            {
                agentcolor = "Yellow";
                var YellowRand = Random.Range(0, 100);

                if (YellowRand <= 22)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home1.transform.position;
                    numb3++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Yellow);
                }
                else if (YellowRand <= 55)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home2.transform.position;
                    numb2++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Yellow);
                }
                else if (YellowRand <= 85)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home3.transform.position;
                    numb1++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Yellow);
                }
                else if (YellowRand <= 100)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home4.transform.position;
                    numb0++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Yellow);
                }
            }
            else if (rand3 <= 100)
            {
                agentcolor = "Blue";
                var BlueRand = Random.Range(0, 100);

                if (BlueRand <= 10)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home1.transform.position;
                    numb3++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Blue);
                }
                else if (BlueRand <= 28)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home2.transform.position;
                    numb2++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Blue);
                }
                else if (BlueRand <= 57)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home3.transform.position;
                    numb1++;
                    agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Blue);
                }
                else if (BlueRand <= 100)
                {
                    agentsnuts = Instantiate(Agent1, spawnlocation);
                    agentsnuts.GetComponent<NavMeshAgent>().destination = home4.transform.position;
                    numb0++;
                     agentsnuts.GetComponent<Renderer>().material.SetColor("_Color", Blue);
                }
            }
        }
    }
}
//blue-fighting, red FPS, green Strategy, Yellow Sports, black others
//fighting 32%, fps 21%, strategy 10%, sports 24%, other 13%