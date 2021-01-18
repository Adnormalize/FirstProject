using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrols : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _navMeshAgent;
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;
    private int _currentWaypointIndex;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _navMeshAgent.SetDestination(_waypoints[0].position);
    }

    private void Update()
    {
        if (_navMeshAgent.remainingDistance < _navMeshAgent.stoppingDistance)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
            _navMeshAgent.SetDestination(_waypoints[_currentWaypointIndex].position);
        }
    }
}
