using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FallGround : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Player>(out Player _player))
        {
            _rigidBody.useGravity = true;
            _rigidBody.velocity = new Vector3(_rigidBody.velocity.x, -9f, _rigidBody.velocity.z);
        }
    }
}

