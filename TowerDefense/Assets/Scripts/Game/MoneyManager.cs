using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public int playerMoney = 0;
    public TextMeshProUGUI MoneyText;

    public void Start()
    {
        playerMoney = 200;
        MoneyText.text = playerMoney.ToString();
    }

    public void Update()
    {
        MoneyText.text = playerMoney.ToString();
    }
}
