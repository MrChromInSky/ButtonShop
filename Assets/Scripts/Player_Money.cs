using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player_Money : MonoBehaviour
{
    [Header("Players Money")]
    public int playerMoney;

    [Header("Other")]
    public TextMeshProUGUI moneyText;


    void Update()
    {
        //Setting money text//
        moneyText.SetText("Money: " + playerMoney.ToString());

        //If somehow a player has negative funds it will reset them.
        if (playerMoney < 0)
        {
            playerMoney = 0;
        }
    }
}
