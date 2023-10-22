using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static int money;
    public int startMoney = 0;

    public TextMeshProUGUI moneyText;

    void Start()
    {
        money = startMoney;
    }

    void Update()
    {
        moneyText.text = "MONEY: $" + money.ToString();
    }

}
