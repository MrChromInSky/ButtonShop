using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Button_Controller : MonoBehaviour
{
    //Declarations
    Player_Money playerMoney;


    void Awake()
    {
        playerMoney = GameObject.FindGameObjectWithTag("GameController").GetComponent<Player_Money>();
    }

    public void AddMoney()
    {
        playerMoney.playerMoney += 100;
    }
}


