using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

public class StaticVariables : MonoBehaviour
{
    public GameObject userID;
    private String[] Lines;
    
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
        Debug.Log(userName);
        Debug.Log(coins);
        Debug.Log(costume);
        Debug.Log(numberOfFish);
    }

    public void changeUserUpdate() {


    }

    public void changeUserSignOut() {
        userName = "guest";
        coins = "0";
        costume = "0";
        numberOfFish = "0";
    }
}
