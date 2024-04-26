using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerJump : MonoBehaviour
{
    private Rigidbody _rigidBody;
    [SerializeField] private float _force;
    void Start() => _rigidBody = GetComponent<Rigidbody>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (PlayerGroundChecker._onGround)
        {
            _rigidBody.AddForce(Vector3.up * _force);
            _rigidBody.velocity = new Vector3(_rigidBody.velocity.x, _rigidBody.velocity.y - 4f);
        }
    }
}
