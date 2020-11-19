using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    [SerializeField] private int coin = 100;
    private Text coinText;

    private void Start()
    {
        coinText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        coinText.text = coin.ToString();
    }

    public void addCoin(int revenue)
    {
        coin += revenue;
        UpdateDisplay();
    }
    
    public void spendCoin(int revenue)
    {
        if (coin >= revenue)
        {
            coin -= revenue; 
            UpdateDisplay();
        }
    }
}
