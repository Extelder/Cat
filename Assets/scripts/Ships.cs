using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.TryGetComponent<Player>(out Player _player))
        {
            _animator.SetTrigger("Attack");
        }
    }
}
