using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

public class BuyCostume : MonoBehaviour
{

    public GameObject playerCoins;
    public GameObject costumeCost;

    public GameObject notEnoughCoinsPopUp;
    public GameObject costumeDeleteButton;
    public GameObject costumeEquipButton;
    
    private string playerCoin1;
    private int playerCoin2;
    private string costumeCoin1;
    private int costumeCoin2;

    public void BuyOperation() {

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            costumeDeleteButton.SetActive(false);
            costumeEquipButton.SetActive(true);
        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }

    }
    
}
