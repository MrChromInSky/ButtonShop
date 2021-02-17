using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Unlock_Button_Controller : MonoBehaviour
{
    Player_Money playerMoney;

    public bool isTheLast;

    [Header("Next Button")]
    public GameObject NextButton;

    [Header("Arrow to next upgrade")]
    public GameObject buyArrow;
    public int ArrowPrice;

    [Header("Buton Blocker")]
    public GameObject buttonblocker;

    private void Awake()
    {
        playerMoney = GameObject.FindWithTag("GameController").GetComponent<Player_Money>();
    }

    private void Start()
    {
        buyArrow.GetComponentInChildren<TextMeshProUGUI>().SetText("Next: " + ArrowPrice.ToString());
    }

    public void ArrowClick()
    {
        if (playerMoney.playerMoney >= ArrowPrice)
        {
            playerMoney.playerMoney -= ArrowPrice;
            NextButton.GetComponent<Unlock_Button_Controller>().Unlocked();
            buyArrow.SetActive(false);
        }
        else
        {

        }
    }

    public void Unlocked()
    {
        if(isTheLast)
        {
            buttonblocker.SetActive(false);
        }
        else
        {
            buttonblocker.SetActive(false);

            buyArrow.SetActive(true);
        }            
    }
}
