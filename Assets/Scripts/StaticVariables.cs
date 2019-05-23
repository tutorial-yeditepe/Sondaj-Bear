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
    
    public Login LoginWindow;

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

    public void changeUserUpdate() {

        if(sceneIndex == "0") {
            sceneIndex = "1";
            Debug.Log(sceneIndex);
        }else {
            sceneIndex = "0";
            Debug.Log(sceneIndex);
        }
                
    }

    public void changeUserSignOut() {

        userName = "guest";
        coins = "0";
        costume = "0";
        numberOfFish = "0";
        userLogged = "0";
    }

    void Start() {

        if(userLogged == "1" && sceneIndex == "0") {
        
            LoginWindow.LoginUpdate(userName,coins);
            Debug.Log(sceneIndex);

        }
        Debug.Log(sceneIndex);
        
    }
}
