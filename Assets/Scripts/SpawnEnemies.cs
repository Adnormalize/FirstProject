using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    [SerializeField] private Transform _position;

    void Start()
    {
        Instantiate(_enemy, _position.position, Quaternion.identity);
    }
}
