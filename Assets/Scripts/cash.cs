using UnityEngine;
using UnityEngine.UI;

public class Cash : MonoBehaviour
{
    public Text moneyText;
    public Text mpsText;
    public float money;
    public float jewMps = 1.0f;
    public float stockMps = 1.0f;
    public float slaveMps = 1.0f;
    public float nineElevenMps = 1.0f;
    public float daenenMps = 1.0f;
    public float pizzeriaMps = 1.0f;
    public float tacoStandMps = 1.0f;
    public float creditCardMps = 1.0f;
    public float mps = 1;
    private float timer;
    private float updateInterval = 1.0f;

    private void Update()
    {
        mps = jewMps + stockMps + slaveMps + nineElevenMps + daenenMps + pizzeriaMps + tacoStandMps + creditCardMps;
        money += (mps * Time.deltaTime);
        money = Mathf.Round(money * 10.0f) * 0.1f;

        timer += Time.deltaTime;
        if (timer >= updateInterval)
        {
            money += mps;
            money = Mathf.Round(money * 10.0f) * 0.1f;
            timer = 0.0f;
        }

        moneyText.text = FormatFloatValue(money);
        mpsText.text = FormatFloatValue(mps);
    }
    public void OnMouseDown()
    {
        money++;
        moneyText.text = money.ToString();
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
