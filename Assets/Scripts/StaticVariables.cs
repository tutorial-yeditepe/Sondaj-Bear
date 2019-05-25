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
    static public string trophy1 = "0";
    static public string trophy2 = "0";
    static public string trophy3 = "0";

    //When a user logged in.
    public void changeUserLogged() {

        userName = userID.GetComponent<TextMeshProUGUI>().text;
        Lines = System.IO.File.ReadAllLines(Application.persistentDataPath+"/"+userName+".txt");
        coins = Lines[1];
        costume = Lines[2];
        trophy1 = Lines[12];
        trophy2 = Lines[13];
        trophy3 = Lines[14];
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
        trophy1 = "0";
        trophy2 = "0";
        trophy3 = "0";
        userLogged = "0";
    }

    //When a game over happens.
    public void gameOverProtocol() {

        //Update user info. Such as coins, number of fish cought and trophies.
        playerCoins = playerStats.GetComponent<PlayerStats>().coins.ToString();
        playerScore = playerStats.GetComponent<PlayerStats>().totalPoint.ToString();
        playerFishCount = playerStats.GetComponent<PlayerStats>().totalFish.ToString();
        playerTrophy1 = playerStats.GetComponent<PlayerStats>().trophy1.ToString();
        playerTrophy2 = playerStats.GetComponent<PlayerStats>().trophy2.ToString();
        playerTrophy3 = playerStats.GetComponent<PlayerStats>().trophy3.ToString();

        if (userName != "guest")
        {
            Lines = System.IO.File.ReadAllLines(Application.persistentDataPath + "/" + userName + ".txt");
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
            System.IO.File.WriteAllText(Application.persistentDataPath + "/" + userName + ".txt", form);
            Debug.Log(form);
        }

        //Check highscores and update highscores table.
        Lines = System.IO.File.ReadAllLines(Application.persistentDataPath+"/highscores.txt");

        List<string> scoresArray = new List<string>();
        List<string> namesArray = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            if (Lines[2 * i] != "--")
            {
                namesArray.Add(Lines[2*i]);
                scoresArray.Add(Lines[2*i+1]);
            }
            else
            {
                break;
            }
        }
        scoresArray.Add(playerScore);
        namesArray.Add(userName);

        int length = scoresArray.Count;
        for (int i = 0; i < length; i++)
        {
            for (int j = 1; j < length; j++)
            {
                if (int.Parse(scoresArray[j - 1]) > int.Parse(scoresArray[j]))
                {
                    string temp = scoresArray[j - 1];
                    scoresArray[j - 1] = scoresArray[j];
                    scoresArray[j] = temp;

                    temp = namesArray[j -1];
                    namesArray[j - 1] = namesArray[j];
                    namesArray[j] = temp;
                }
            }
        }

        namesArray.Reverse();
        scoresArray.Reverse();

        form = namesArray[0] + Environment.NewLine + scoresArray[0];
        for (int i = 1; i < 5; i++)
        {
            if (i < namesArray.Count)
            {
                form += Environment.NewLine + namesArray[i] + Environment.NewLine + scoresArray[i];
            }
            else
            {
                form += Environment.NewLine + "--" + Environment.NewLine + "--";
            }
        }
        System.IO.File.WriteAllText(Application.persistentDataPath + "/highscores.txt", form);
        sceneIndex = "0";  
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
