using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;

    NavMeshAgent navMeshAgent;
    float distanceToTarger = Mathf.Infinity; 
    


    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarger = Vector3.Distance(target.position, transform.position);
        
        if(distanceToTarger <= chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }
}
