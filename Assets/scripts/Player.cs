using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void CoinTake();
    public event CoinTake OnCoinTake;
    

    public static Player _singleton { get; private set; }

    private void Awake()
    {
        _singleton = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Coin>(out Coin coin))
        {
            OnCoinTake.Invoke();
            coin.OnCoinTaked();
        }
    }
    

}
