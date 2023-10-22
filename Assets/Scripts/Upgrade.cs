using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{

    // Depth Upgrade
    public GameObject depth2;
    public GameObject depth3;
    public GameObject depth4;
    public GameObject depth5;
    public GameObject depth6;

    public TextMeshProUGUI priceDepthText;

    public int upgradeLevelDepth = 1;

    public static int priceDepth;

    public GameObject upgradeButtonLine;

    // Hook Upgrade

    public GameObject hook;
    Hook inv;

    public TextMeshProUGUI priceHookText;

    public int upgradeLevelHook = 1;

    public static int priceHook;
    public int hookUp = 2;

    public GameObject upgradeButtonHook;

    void Start()
    {
        inv = hook.GetComponent<Hook>();

    }

    void Update()
    {
        //Depth Upgrades
        if (upgradeLevelDepth >= 2)
        {
            depth2.SetActive(false);
        }
        if (upgradeLevelDepth >= 3)
        {
            depth3.SetActive(false);
        }
        if (upgradeLevelDepth >= 4)
        {
            depth4.SetActive(false);
        }
        if (upgradeLevelDepth >= 5)
        {
            depth5.SetActive(false);
        }
        if (upgradeLevelDepth >= 6)
        {
            depth6.SetActive(false);
            upgradeButtonLine.SetActive(false);

        }
        priceDepth = upgradeLevelDepth * 50;
        priceDepthText.text = "$" + priceDepth.ToString();

        // Hook Upgrades

        if (upgradeLevelHook >= 6)
        {

            upgradeButtonHook.SetActive(false);
        }

        priceHook = upgradeLevelHook * 50;
        priceHookText.text = "$" + priceHook.ToString();

    }


    public void UpgradeDepth()
    {
        if (PlayerStats.Money >= priceDepth)
        {
            PlayerStats.Money -= priceDepth;
            upgradeLevelDepth++;

            Debug.Log("UPGRADE BOUGHT: DEPTH UPGRADE");
        }

    }

    public void UpgradeHook()
    {
        if (PlayerStats.Money >= priceHook)
        {
            PlayerStats.Money -= priceHook;
            upgradeLevelHook++;
            inv.maxFish += hookUp;

            Debug.Log("UPGRADE BOUGHT: HOOK UPGRADE");
        }

    }


}
