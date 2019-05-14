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
    public GameObject UserName;

    public GameObject notEnoughCoinsPopUp;
    public GameObject costumeNotBought;
    public GameObject costumeBought;
    
    private string playerCoin1;
    private int playerCoin2;
    private string costumeCoin1;
    private int costumeCoin2;

    private String[] Lines;
    private string userName;
    private string form;

    public void BuyOperation1() {

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt");

            form = Lines[0] + Environment.NewLine + playerCoin1 + Environment.NewLine + "1" + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6]; 
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt",form);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }

    }

    public void BuyOperation2() {
        
        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt");

            form = Lines[0] + Environment.NewLine + playerCoin1 + Environment.NewLine + Lines[2] + Environment.NewLine + "1" + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6]; 
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt",form);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }
    }

    public void BuyOperation3() {

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt");

            form = Lines[0] + Environment.NewLine + playerCoin1 + Environment.NewLine + Lines[2] + Environment.NewLine + Lines[3] + Environment.NewLine + "1" + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6]; 
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt",form);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }
    }

    public void BuyOperation4() {

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt");

            form = Lines[0] + Environment.NewLine + playerCoin1 + Environment.NewLine + Lines[2] + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + "1" + Environment.NewLine + Lines[6]; 
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt",form);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }
    }

    public void BuyOperation5() {

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt");

            form = Lines[0] + Environment.NewLine + playerCoin1 + Environment.NewLine + Lines[2] + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + "1"; 
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+userName+".txt",form);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }
    }
    
    
}
