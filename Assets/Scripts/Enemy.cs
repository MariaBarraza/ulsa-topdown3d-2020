using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField, Range(0.1f,10f)]
    float moveSpeed;

    [SerializeField, Range(0f,10f)]
    float minDistance;

    NavMeshAgent navMeshAgent;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(Attack)
        {
            navMeshAgent.destination = GameManager.instance.Player.transform.position;
            transform.LookAt(GameManager.instance.Player.transform);
        }   
    }

    public bool Attack
    {
        get => Vector3.Distance(this.transform.position,GameManager.instance.Player.transform.position) <= minDistance;
    }
}
