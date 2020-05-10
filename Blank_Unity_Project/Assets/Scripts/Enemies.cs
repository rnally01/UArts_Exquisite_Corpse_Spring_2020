using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemies : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private Vector3 agentHome;
    private Vector3 destination;
    private float distanceBetween;
    public float minimumChaseDistance = 4f;
    public float maximumChaseDistance = 25f;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;

        agentHome = agent.transform.position;
    }

    private void Update()
    {
        distanceBetween = Vector3.Distance(agent.transform.position, player.position);

        //Debug.Log(distanceBetween);

        if (distanceBetween > minimumChaseDistance && distanceBetween < maximumChaseDistance)
        {
            destination = player.position;
            agent.destination = destination;
            //gameObject.transform.LookAt(player);
        }

        if (distanceBetween < minimumChaseDistance)
        {
            //Debug.Log("Shut up, too close");
        }

        if (distanceBetween > maximumChaseDistance)
        {
            //Debug.Log("too far");
            destination = agentHome;
            agent.destination = destination;
        }
    }
}
