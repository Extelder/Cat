using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damaged : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth _health))
        {
            _health.TakeDamage(_damage);
        }
    }
}
