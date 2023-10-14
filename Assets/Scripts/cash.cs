using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class cash : MonoBehaviour
{
    public Text MoneyText;
    public int money = 0;
    public int mps = 1;
    private float timer = 0.0f;
    private float updateInterval = 1.0f;

    private void Update()
    {
        money += (int)(mps * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= updateInterval)
        {
            money += mps;
            timer = 0.0f;
        }

        MoneyText.text = money.ToString();
    }
    public void OnMouseDown()
    {
        money++;
        MoneyText.text = money.ToString();
    }

}
