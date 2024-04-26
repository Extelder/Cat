using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Trap : MonoBehaviour
{
    private Rigidbody _rigidBody;
    [SerializeField] private float _gravity;
    
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Player>(out Player _player))
        {
          _rigidBody.useGravity = true;
            _rigidBody.velocity = new Vector3(0f, _gravity, 0f);
        }
    }


}
