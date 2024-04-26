using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject _explosionEffect;
    [SerializeField] private Transform _explosionPlace;


    public void OnCoinTaked()
    {
        Instantiate(_explosionEffect, _explosionPlace.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
