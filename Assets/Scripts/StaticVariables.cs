using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

public class StaticVariables : MonoBehaviour
{
    //Varianbles for getting data.
    public GameObject userID;
    public GameObject playerStats;

    //Variables for saving data.
    private String[] Lines;
    private string form;    
    public Login LoginWindow;
    public string playerFishCount;
    public string playerCoins;
    public string playerScore;
    public string playerTrophy1;
    public string playerTrophy2;
    public string playerTrophy3;

    //Static variables.
    static public string userLogged = "0";
    static public string sceneIndex = "0";
    static public string userName = "guest";
    static public string coins = "0";
    static public string costume = "0";
    static public string numberOfFish = "0";

    public void changeUserLogged() {

        userName = userID.GetComponent<TextMeshProUGUI>().text;
        Lines = System.IO.File.ReadAllLines(Application.persistentDataPath+"/"+userName+".txt");
        coins = Lines[1];
        costume = Lines[2];
        numberOfFish = Lines[15];
        userLogged = "1";
        Debug.Log(userName);
        Debug.Log(coins);
        Debug.Log(costume);
        Debug.Log(numberOfFish);
    }

    //Line checking as follows: 
    //password / coin / currentCostume / #ofcostumes /costume1 / costume2 / costume3 / costume4 / costume5 / trophy1 / trophy2 / trophy3 / trophy4 / trophy5 / trophy6 / numberOfCatchFish

    //For switching between scenes.
    public void changeUserUpdate() {

        if(sceneIndex == "0") {
            sceneIndex = "1";
            Debug.Log(sceneIndex);
        }else {
            sceneIndex = "0";
            Debug.Log(sceneIndex);
        }
                
    }

    //When a user signs out.
    public void changeUserSignOut() {
        userName = "guest";
        coins = "0";
        costume = "0";
        numberOfFish = "0";
        userLogged = "0";
    }

    //When a game over happens.
    public void gameOverProtocol() {

        if(sceneIndex == "0") {
            sceneIndex = "1";
            Debug.Log(sceneIndex);
        }else {
         
            playerCoins = playerStats.GetComponent<PlayerStats>().coins.ToString();
            playerScore = playerStats.GetComponent<PlayerStats>().totalPoint.ToString();

            Lines = System.IO.File.ReadAllLines(Application.persistentDataPath+"/"+userName+".txt");
            form = Lines[0] 
                + Environment.NewLine + playerCoins 
                + Environment.NewLine + Lines[2] 
                + Environment.NewLine + Lines[3] 
                + Environment.NewLine + Lines[4] 
                + Environment.NewLine + Lines[5] 
                + Environment.NewLine + Lines[6] 
                + Environment.NewLine + Lines[7] 
                + Environment.NewLine + Lines[8] 
                + Environment.NewLine + Lines[9] 
                + Environment.NewLine + Lines[10] 
                + Environment.NewLine + Lines[11] 
                + Environment.NewLine + playerTrophy1 
                + Environment.NewLine + playerTrophy2 
                + Environment.NewLine + playerTrophy3
                + Environment.NewLine + playerFishCount;

            System.IO.File.WriteAllText(Application.persistentDataPath+"/"+userName+".txt",form);
            sceneIndex = "0";
            Debug.Log(form);
        }


    }

    //Check at every start of every scene.
    void Start() {

        if(userLogged == "1" && sceneIndex == "0") {
        
            LoginWindow.LoginUpdate(userName);
            Debug.Log(sceneIndex);

        }
        Debug.Log(sceneIndex);
        
    }
}
