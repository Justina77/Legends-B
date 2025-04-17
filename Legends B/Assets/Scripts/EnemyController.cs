using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) > 1f)
        {
            navMeshAgent.SetDestination(player.position);
            animator.SetBool("running", true);
        }
        else
        {
            navMeshAgent.isStopped = true;
            animator.SetBool("running", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        //Destroy(gameObject);
    }
}
