using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class OrbitBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform[] orbitPoints;
    private int orbitPoint = 0;
    //public Vector3DataList orbitList;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        /*for (int i = 0; i < orbitPoints.Length; i++)
        {
            orbitPoints[i].position = orbitList[1];
        }
        */
        GotoNextPoint();
    }
    
    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
    
    void GotoNextPoint() {
        

        // Set the agent to go to the currently selected destination.
        agent.destination = orbitPoints[orbitPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        orbitPoint = (orbitPoint + 1) % orbitPoints.Length;
    }
}
