using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

public class BuyCostume : MonoBehaviour
{
    //Variables.
    public GameObject playerCoins;
    public GameObject costumeCost;
    public GameObject UserName;

    //Button variables.
    public GameObject notEnoughCoinsPopUp;
    public GameObject costumeNotBought;
    public GameObject costumeBought;
    
    //Variables for coin calculation.
    private string playerCoin1;
    private int playerCoin2;
    private string costumeCoin1;
    private int costumeCoin2;

    //Variables for trophy unlocking
    private string numberOfCostumes;
    private int numberOfCostumesTrophy;
    public GameObject trophyMessagePanel;
    public GameObject trophyCostume1;
    public GameObject trophyCostume2;
    public GameObject trophyCostume3;

    //Variables for saving data.
    private String[] Lines;
    private string userName;
    private string form;

    //Line checking as follows: 
    //password / coin / currentCostume / #ofcostumes /costume1 / costume2 / costume3 / costume4 / costume5 / trophy1 / trophy2 / trophy3 / trophy4 / trophy5 / trophy6 /

    //These BuyOperation methods basically does:
    //Check if coin is enough to buy.
    //If enough confirm buy and change necessary variables at .txt file.
    //If not show error pop-up message.

    public void BuyOperation1() {       //Buy operation for costume1.

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();

            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

            //For trophy unlocking.
            numberOfCostumes = Lines[3];
            numberOfCostumesTrophy = Int32.Parse(numberOfCostumes);
            numberOfCostumesTrophy = numberOfCostumesTrophy + 1;
            Debug.Log(numberOfCostumesTrophy);

            if(numberOfCostumesTrophy == 1) {      //Unlock trophyCostume1 

                numberOfCostumes = numberOfCostumesTrophy.ToString();
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume1.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 3) {     //Unlock trophyCostume2

                numberOfCostumes = numberOfCostumesTrophy.ToString(); 
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume2.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 5) {     //Unlock trophyCostume3

                numberOfCostumes = numberOfCostumesTrophy.ToString(); 
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume3.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else {

                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

            }
            
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }

    }

    public void BuyOperation2() {       //Buy operation for costume2.
        
        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();
            
            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

            //For trophy unlocking.
            numberOfCostumes = Lines[3];
            numberOfCostumesTrophy = Int32.Parse(numberOfCostumes);
            numberOfCostumesTrophy = numberOfCostumesTrophy + 1;
            Debug.Log(numberOfCostumesTrophy);

            if(numberOfCostumesTrophy == 1) {      //Unlock trophyCostume1 

                numberOfCostumes = numberOfCostumesTrophy.ToString();
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes  
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume1.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 3) { //Unlock trophyCostume2

                numberOfCostumes = numberOfCostumesTrophy.ToString();
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume2.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 5) { //Unlock trophyCostume3

                numberOfCostumes = numberOfCostumesTrophy.ToString();
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume3.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else {

                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

            }
            
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }
    }

    public void BuyOperation3() {       //Buy operation for costume3.

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();

            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

            //For trophy unlocking.
            numberOfCostumes = Lines[3];
            numberOfCostumesTrophy = Int32.Parse(numberOfCostumes);
            numberOfCostumesTrophy = numberOfCostumesTrophy + 1;
            Debug.Log(numberOfCostumesTrophy);

            if(numberOfCostumesTrophy == 1) {      //Unlock trophyCostume1 

                numberOfCostumes = numberOfCostumesTrophy.ToString();
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes  
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume1.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 3) { //Unlock trophyCostume2

                numberOfCostumes = numberOfCostumesTrophy.ToString();
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume2.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 5) { //Unlock trophyCostume3

                numberOfCostumes = numberOfCostumesTrophy.ToString();
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume3.SetActive(true);
                trophyMessagePanel.SetActive(true);
                
            }else {

                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes  
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

            }
            
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }
    }

    public void BuyOperation4() {       //Buy operation for costume4.

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();
            
            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

            //For trophy unlocking.
            numberOfCostumes = Lines[3];
            numberOfCostumesTrophy = Int32.Parse(numberOfCostumes);
            numberOfCostumesTrophy = numberOfCostumesTrophy + 1;
            Debug.Log(numberOfCostumesTrophy);

            if(numberOfCostumesTrophy == 1) {      //Unlock trophyCostume1 

                numberOfCostumes = numberOfCostumesTrophy.ToString(); 
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes  
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5]
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume1.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 3) { //Unlock trophyCostume2

                numberOfCostumes = numberOfCostumesTrophy.ToString(); 
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume2.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 5) { //Unlock trophyCostume3

                numberOfCostumes = numberOfCostumesTrophy.ToString(); 
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume3.SetActive(true);
                trophyMessagePanel.SetActive(true);
                
            }else {

                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

            }
            
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }
    }

    public void BuyOperation5() {       //Buy operation for costume5.

        playerCoin1 = playerCoins.GetComponent<TextMeshProUGUI>().text;
        playerCoin2 = Int32.Parse(playerCoin1);
        costumeCoin1 = costumeCost.GetComponent<TextMeshProUGUI>().text;
        costumeCoin2 = Int32.Parse(costumeCoin1);

        if(playerCoin2 >= costumeCoin2 ) {

            playerCoin2 = playerCoin2 - costumeCoin2;
            playerCoins.GetComponent<TextMeshProUGUI>().text = playerCoin2.ToString();
            playerCoin1 = playerCoin2.ToString();
            
            userName = UserName.GetComponent<TextMeshProUGUI>().text;
            Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

            //For trophy unlocking.
            numberOfCostumes = Lines[3];
            numberOfCostumesTrophy = Int32.Parse(numberOfCostumes);
            numberOfCostumesTrophy = numberOfCostumesTrophy + 1;
            Debug.Log(numberOfCostumesTrophy);

            if(numberOfCostumesTrophy == 1) {      //Unlock trophyCostume1 

                numberOfCostumes = numberOfCostumesTrophy.ToString(); 
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes  
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5]
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume1.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 3) { //Unlock trophyCostume2

                numberOfCostumes = numberOfCostumesTrophy.ToString(); 
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume2.SetActive(true);
                trophyMessagePanel.SetActive(true);

            }else if(numberOfCostumesTrophy == 5) { //Unlock trophyCostume3

                numberOfCostumes = numberOfCostumesTrophy.ToString(); 
                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

                trophyCostume3.SetActive(true);
                trophyMessagePanel.SetActive(true);
                
            }else {

                form = Lines[0] 
                + Environment.NewLine + playerCoin1 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + numberOfCostumes  
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5]
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + "1" 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + Lines[12] 
                + Environment.NewLine + Lines[13] 
                + Environment.NewLine + Lines[14];

            }
            
            System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);
            costumeNotBought.SetActive(false);
            costumeBought.SetActive(true);


        }else {

            notEnoughCoinsPopUp.SetActive(true);
        }
    }
    
    
}
