using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _speed;
    [SerializeField] private Transform _parent;

    private void Start()
    {
        Destroy(gameObject, 4f);
        _parent = PlayerMovement._playerMovement._lama.transform;
        if(_parent.localScale == new Vector3(-1f, 1f, 1f))
        {
            _speed = -_speed;
        }
    }
    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Chicken>(out Chicken _chicken))
        {
            _chicken.TakeDamage(34);
        } 
        Destroy(gameObject);
    }
}
