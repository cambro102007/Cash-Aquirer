using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text buttonText;
    public GameObject cashObject;
    public float price = 0f;
    public int jewsOwned = 0, stocksOwned = 0, slavesOwned = 0;
    public void PurchaseJew()
    {
        buttonText.text = jewsOwned + " Jews: " + price;
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            if (jewsOwned == 0)
            {
                cash.jewMps += 1;
            }
            jewsOwned++;
            cash.money -= price;
            price *= 1.1f;
            cash.jewMps *= 1.05f;
            cash.jewMps = Mathf.Round(cash.jewMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;
        }
    }
    public void PurchaseStock()
    {
        buttonText.text = stocksOwned + " Stocks: " + price;
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            if (stocksOwned == 0)
            {
                cash.stockMps += 1;
            }
            stocksOwned++;
            cash.money -= price;
            price *= 1.2f;
            cash.stockMps *= 1.40f;
            cash.stockMps = Mathf.Round(cash.stockMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;
        }
    }
    public void PurchaseSlave()
    {
        buttonText.text = slavesOwned + " Slaves: " + price;
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            if (slavesOwned == 0)
            {
                cash.slaveMps += 1;
            }
            slavesOwned++;
            cash.money -= price;
            price *= 1.5f;
            cash.slaveMps *= 2.0f;
            cash.slaveMps = Mathf.Round(cash.slaveMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;
        }
    }
}


