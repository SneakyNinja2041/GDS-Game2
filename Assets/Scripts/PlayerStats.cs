using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 0;

    public TextMeshProUGUI moneyText;

    void Start()
    {
        Money = startMoney;
    }

    void Update()
    {
        moneyText.text = "MONEY: $" + Money.ToString();
    }

}
