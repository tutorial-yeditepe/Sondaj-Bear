using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class SignUp : MonoBehaviour
{
    public GameObject username;             //Variables.
    public GameObject password;
    public GameObject signUpPopUp;
    public GameObject emptyPopUp;
    public GameObject usernamePopUp;
    public GameObject shortPasswordPopUp;
    public GameObject shortUsernamePopUp;
    public GameObject successfullPopUp;

    private string Username;
    private string Password;
    private string form;
    private bool usernameValid = false;
    private bool passwordValid = false;

    public void SignUpOperation() {                 //Done button calls this method.

        if(Username != "" && Password != "") {      //Checking if username and password fields are empty or not.

            if(System.IO.File.Exists(Application.persistentDataPath+"/"+Username+".txt")){       //Checking if username is taken.

                usernamePopUp.SetActive(true);

            }else {                        
                if(Username.Length >= 3) {          //Checking if username is short or not

                    usernameValid = true;
                   
                    if(Password.Length >= 5) {      //Checking if password is short or not.

                        passwordValid = true;
                    }else {

                        shortPasswordPopUp.SetActive(true);
                    }
                }else {

                    shortUsernamePopUp.SetActive(true);
                }
            }
            if(usernameValid == true && passwordValid == true) {        //If everthing is valid sign up successful.

                if(Username == "admin") {

                    //Form as follows: password / coin / currentCostume / #ofcostumes /costume1 / costume2 / costume3 / costume4 / costume5 / trophy1 / trophy2 / trophy3 / trophy4 / trophy5 / trophy6 / numberOfCatchFish
                form = Password 
                + Environment.NewLine + "20000" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0"
                + Environment.NewLine + "0";

                }else {
                    //Form as follows: password / coin / currentCostume / #ofcostumes /costume1 / costume2 / costume3 / costume4 / costume5 / trophy1 / trophy2 / trophy3 / trophy4 / trophy5 / trophy6 / numberOfCatchFish
                form = Password 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0" 
                + Environment.NewLine + "0"
                + Environment.NewLine + "0";
                }
                
                
                System.IO.File.WriteAllText(Application.persistentDataPath+"/"+Username+".txt",form);
                successfullPopUp.SetActive(true);
                cleaner();
            }
        }else {

            emptyPopUp.SetActive(true);
        }
    }

    public void cleaner() {             //For resetting input fields.

        username.GetComponent<InputField>().text = "";
        password.GetComponent<InputField>().text = "";
        usernameValid = false;
        passwordValid = false;
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
