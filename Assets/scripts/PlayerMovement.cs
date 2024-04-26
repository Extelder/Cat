using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public Transform _lama;
    [SerializeField] private float _speed;

    private float _xInput;

    public static PlayerMovement _playerMovement { get; private set; }

    private void Awake()
    {
        _playerMovement = this;
    }
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _xInput = Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime;
        _rigidBody.velocity = new Vector3(_xInput, _rigidBody.velocity.y - 45f * Time.deltaTime, 0f);
        if(_xInput >= 0.1f)
        {
            _lama.localScale = new Vector3(1f, 1f, 1f);
        }
        else if(_xInput <= -0.1f)
        {
            _lama.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
}
