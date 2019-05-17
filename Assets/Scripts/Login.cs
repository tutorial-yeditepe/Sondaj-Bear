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

    //Costume variables.
    public GameObject playerCoins;
    public GameObject costume1NotBought;
    public GameObject costume2NotBought;
    public GameObject costume3NotBought;
    public GameObject costume4NotBought;
    public GameObject costume5NotBought;
    public GameObject costume1Bought;
    public GameObject costume2Bought;
    public GameObject costume3Bought;
    public GameObject costume4Bought;
    public GameObject costume5Bought;
    public GameObject currentCostume;
    public GameObject defaultCostume;
    public GameObject costume1Image;
    public GameObject costume2Image;
    public GameObject costume3Image;
    public GameObject costume4Image;
    public GameObject costume5Image;

    //Profile picture variables.
    public GameObject defaultProfile;
    public GameObject Profile1;
    public GameObject Profile2;
    public GameObject Profile3;
    public GameObject Profile4;
    public GameObject Profile5;

    //Trophy checking variables
    public GameObject trophy1;
    public GameObject trophy2;
    public GameObject trophy3;
    public GameObject trophy4;
    public GameObject trophy5;
    public GameObject trophy6;

    private string Username;
    private string Password;
    private string Coins;
    private bool usernameValid = false;
    private bool passwordValid = false;
    private String[] Lines;

    //Line checking as follows: 
    //password / coin / currentCostume / #ofcostumes /costume1 / costume2 / costume3 / costume4 / costume5 / trophy1 / trophy2 / trophy3 / trophy4 / trophy5 / trophy6 /

    public void LoginOperation() {

        if(Username != "" && Password != "") {      //Check if username and password fields are empty or not.

            if(System.IO.File.Exists(Application.persistentDataPath+"/"+Username+".txt")) {        //Check username.

                usernameValid = true;
                Lines = System.IO.File.ReadAllLines(Application.persistentDataPath+"/"+Username+".txt");
  
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
        if(usernameValid == true && passwordValid == true) {    //If everthing is valid, show username and "Play!" texts. Check costumes and trophies.

            //Costume1 checking.
            if(Lines[4] == "0") {

                costume1Bought.SetActive(false);
                costume1NotBought.SetActive(true);
            }else {
                costume1Bought.SetActive(true);
                costume1NotBought.SetActive(false);
            }

            //Costume2 checking.
            if(Lines[5] == "0") {

                costume2Bought.SetActive(false);
                costume2NotBought.SetActive(true);
            }else {

                costume2Bought.SetActive(true);
                costume2NotBought.SetActive(false);

            }

            //Costume3 checking.
            if(Lines[6] == "0") {

                costume3Bought.SetActive(false);
                costume3NotBought.SetActive(true);
            }else {
                costume3Bought.SetActive(true);
                costume3NotBought.SetActive(false);
            }

            //Costume4 checking.
            if(Lines[7] == "0") {

                costume4Bought.SetActive(false);
                costume4NotBought.SetActive(true);
            }else {

                costume4Bought.SetActive(true);
                costume4NotBought.SetActive(false);

            }

            //Costume5 checking.
            if(Lines[8] == "0") {

                costume5Bought.SetActive(false);
                costume5NotBought.SetActive(true);
            }else {

                costume5Bought.SetActive(true);
                costume5NotBought.SetActive(false);

            }

            //Equip the current costume.

            if(Lines[2] == "0") {       //Default costume equipped.

                currentCostume.GetComponent<Image>().sprite = defaultCostume.GetComponent<Image>().sprite;

            }else if(Lines[2] == "1") {     //Costume1 equipped.

                currentCostume.GetComponent<Image>().sprite = costume1Image.GetComponent<Image>().sprite;

            }else if(Lines[2] == "2") {     //Costume2 equipped.

                currentCostume.GetComponent<Image>().sprite = costume2Image.GetComponent<Image>().sprite;

            }else if(Lines[2] == "3") {     //Costume3 equipped.

                currentCostume.GetComponent<Image>().sprite = costume3Image.GetComponent<Image>().sprite;

            }else if(Lines[2] == "4") {     //Costume4 equipped.

                currentCostume.GetComponent<Image>().sprite = costume4Image.GetComponent<Image>().sprite;

            }else if(Lines[2] == "5") {     //Costume5 equipped.

                currentCostume.GetComponent<Image>().sprite = costume5Image.GetComponent<Image>().sprite;
            }

            //Change profile picture according to the costume.

            if(Lines[2] == "0") {       //Set profile picture to default.

                defaultProfile.SetActive(true);
                Profile1.SetActive(false);
                Profile2.SetActive(false);
                Profile3.SetActive(false);
                Profile4.SetActive(false);
                Profile5.SetActive(false);

            }else if(Lines[2] == "1") {     //Set profile picture to picture1.

                defaultProfile.SetActive(false);
                Profile1.SetActive(true);
                Profile2.SetActive(false);
                Profile3.SetActive(false);
                Profile4.SetActive(false);
                Profile5.SetActive(false);

            }else if(Lines[2] == "2") {     //Set profile picture to picture2.

                defaultProfile.SetActive(false);
                Profile1.SetActive(false);
                Profile2.SetActive(true);
                Profile3.SetActive(false);
                Profile4.SetActive(false);
                Profile5.SetActive(false);

            }else if(Lines[2] == "3") {     //Set profile picture to picture3.

                defaultProfile.SetActive(false);
                Profile1.SetActive(false);
                Profile2.SetActive(false);
                Profile3.SetActive(true);
                Profile4.SetActive(false);
                Profile5.SetActive(false);

            }else if(Lines[2] == "4") {     //Set profile picture to picture4.

                defaultProfile.SetActive(false);
                Profile1.SetActive(false);
                Profile2.SetActive(false);
                Profile3.SetActive(false);
                Profile4.SetActive(true);
                Profile5.SetActive(false);

            }else if(Lines[2] == "5") {     //Set profile picture to picture5.

                defaultProfile.SetActive(false);
                Profile1.SetActive(false);
                Profile2.SetActive(false);
                Profile3.SetActive(false);
                Profile4.SetActive(false);
                Profile5.SetActive(true);
            }

            //Check and show unlocked trophies;
            if(Lines[9] == "1") {           //Trophy1
                trophy1.SetActive(true);
            }else {
                trophy1.SetActive(false);
            }

            if(Lines[10] == "1") {      //Trophy2
                trophy2.SetActive(true);
            }else {
                trophy2.SetActive(false);
            }

            if(Lines[11] == "1") {      //Trophy3
                trophy3.SetActive(true);
            }else {
                trophy3.SetActive(false);
            }

            if(Lines[12] == "1") {      //Trophy4
                trophy4.SetActive(true);
            }else {
                trophy4.SetActive(false);
            }

            if(Lines[13] == "1") {      //Trophy5
                trophy5.SetActive(true);
            }else {
                trophy5.SetActive(false);
            }

            if(Lines[14] == "1") {      //Trophy6
                trophy6.SetActive(true);
            }else {
                trophy6.SetActive(false);
            }
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
