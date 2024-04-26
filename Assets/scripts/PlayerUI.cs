using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Text _coinText;
    private float coins;

    void Start()
    {
        coins = PlayerPrefs.GetFloat("Coins");
        ResetCoinText();
        Player._singleton.OnCoinTake += CoinTaked;
    }

    public void CoinTaked()
    {
        coins += 1f;
        PlayerPrefs.SetFloat("Coins", coins);
        ResetCoinText();
    }

    void ResetCoinText()
    {
        _coinText.text = coins.ToString();
    }
}
