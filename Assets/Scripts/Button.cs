using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text buttonText;
    public GameObject cashObject;
    public float price;
    public int jewsOwned, stocksOwned, slavesOwned, nineElevensOwned, daenensOwned, pizzeriasOwned, tacoStandsOwned, creditCardsOwned;

    public void PurchaseJew()
    {
        buttonText.text = jewsOwned + " Jews: " + FormatFloatValue(price);
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            jewsOwned++;
            cash.money -= price;
            price *= 1.3f;
            cash.jewMps += 1.0f;
            cash.jewMps *= 1.1f;
            cash.jewMps = Mathf.Round(cash.jewMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;
        }
    }

    public void PurchaseStock()
    {
        buttonText.text = stocksOwned + " Stocks: " + FormatFloatValue(price);
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            stocksOwned++;
            cash.money -= price;
            price *= 1.3f;
            cash.stockMps += 5f;
            cash.stockMps *= 1.1f;
            cash.stockMps = Mathf.Round(cash.stockMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;
        }
    }

    public void PurchaseSlave()
    {
        buttonText.text = slavesOwned + " Slaves: " + FormatFloatValue(price);
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            slavesOwned++;
            cash.money -= price;
            price *= 1.3f;
            cash.slaveMps += 50f;
            cash.slaveMps *= 1.1f;
            cash.slaveMps = Mathf.Round(cash.slaveMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;
        }
    }

    public void PurchaseNineEleven()
    {
        buttonText.text = nineElevensOwned + " NineElevens: " + FormatFloatValue(price);
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            nineElevensOwned++;
            cash.money -= price;
            price *= 1.3f;
            cash.nineElevenMps += 150.0f;
            cash.nineElevenMps *= 1.1f;
            cash.nineElevenMps = Mathf.Round(cash.nineElevenMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;
        }
    }

    public void PurchaseDaenen()
    {
        buttonText.text = daenensOwned + " Daenens: " + FormatFloatValue(price);
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            daenensOwned++;
            cash.money -= price;
            price *= 1.3f;
            cash.daenenMps += 500.0f;
            cash.daenenMps *= 1.1f;
            cash.daenenMps = Mathf.Round(cash.daenenMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;

        }
    }
    public void Purchasepizzeria()
    {
        buttonText.text = pizzeriasOwned + " Pizzerias: " + FormatFloatValue(price);
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            pizzeriasOwned++;
            cash.money -= price;
            price *= 1.4f;
            cash.pizzeriaMps += 2000.0f;
            cash.pizzeriaMps *= 1.1f;
            cash.pizzeriaMps = Mathf.Round(cash.pizzeriaMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;

        }
    }
    public void PurchaseTacoStand()
    {
        buttonText.text = tacoStandsOwned + " TacoStands: " + FormatFloatValue(price);
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            tacoStandsOwned++;
            cash.money -= price;
            price *= 1.4f;
            cash.tacoStandMps += 5000.0f;
            cash.tacoStandMps *= 1.1f;
            cash.tacoStandMps = Mathf.Round(cash.tacoStandMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;

        }
    }
    public void PurchaseCreditCard()
    {
        buttonText.text = creditCardsOwned + " Credit Cards: " + FormatFloatValue(price);
        Cash cash = cashObject.GetComponent<Cash>();
        if (cash.money > price)
        {
            creditCardsOwned++;
            cash.money -= price;
            price *= 1.4f;
            cash.creditCardMps += 30000.0f;
            cash.creditCardMps *= 1.1f;
            cash.creditCardMps = Mathf.Round(cash.creditCardMps * 100.0f) * 0.01f;
            price = Mathf.Round(price * 10.0f) * 0.1f;

        }
    }

    string FormatFloatValue(float floatValue)
    {
        if (floatValue >= 1000000000000)
        {
            return (floatValue / 1000000000000f).ToString("F2") + "T";
        }
        else if (floatValue >= 1000000000)
        {
            return (floatValue / 1000000000f).ToString("F2") + "B";
        }
        else if (floatValue >= 1000000)
        {
            return (floatValue / 1000000f).ToString("F2") + "M";
        }
        else
        {
            return floatValue.ToString("F2");
        }
    }
}


