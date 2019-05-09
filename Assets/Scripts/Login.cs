using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    public GameObject loginUpPopUp;
    public GameObject emptyPopUp;
    public GameObject usernamePopUp;
    public GameObject passwordPopUp;
    public GameObject successPopUp;

    public GameObject changedUsername;
    public GameObject playGuestButton;
    public GameObject playButton;

    public GameObject playerCoins;

    private string Username;
    private string Password;
    private string Coins;
    private bool usernameValid = false;
    private bool passwordValid = false;
    private String[] Lines;

    public void LoginOperation() {

        if(Username != "" && Password != "") {      //Check if username and password fields are empty or not.

            if(System.IO.File.Exists(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+Username+".txt")) {        //Check username.

                usernameValid = true;
                Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/Login/"+Username+".txt");
  
                if(Password == Lines[0]) {          //Check password.

                    passwordValid = true;
                    Coins = Lines[1];
                }else {

                    passwordPopUp.SetActive(true);
                }

            }else {

                usernamePopUp.SetActive(true);
            }
        }else {

            emptyPopUp.SetActive(true);
        }
        if(usernameValid == true && passwordValid == true) {    //If everthing is valid, show username and "Play!" texts.
            successPopUp.SetActive(true);
            changedUsername.GetComponent<TextMeshProUGUI>().text = Username;
            playerCoins.GetComponent<TextMeshProUGUI>().text = Coins;
            playGuestButton.SetActive(false);
            playButton.SetActive(true);
            cleaner();
        }
    }

    public void cleaner() {             //For resetting input fields.

        username.GetComponent<InputField>().text = "";
        password.GetComponent<InputField>().text = "";
        usernameValid = false;
        passwordValid = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        Username = Username.Replace(" ","");
        Password = Password.Replace(" ","");
        username.GetComponent<InputField>().text = Username;
        password.GetComponent<InputField>().text = Password;
    }
}
