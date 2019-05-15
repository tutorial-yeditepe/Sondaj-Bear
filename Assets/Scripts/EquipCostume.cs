using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

public class EquipCostume : MonoBehaviour
{
    //Variables.
    public GameObject characterImage;
    public GameObject costumeImage;
    public GameObject UserName;

    public Sprite characterSprite;
    public Sprite costumeSprite;

    //Profile picture variables.
    public GameObject defaultProfile;
    public GameObject Profile1;
    public GameObject Profile2;
    public GameObject Profile3;
    public GameObject Profile4;
    public GameObject Profile5;

    private String[] Lines;
    private string userName;
    private string form;

    //These EquipOperations basically does:
    //Collect user data then change necessary images.
    //Update the currentCostume part at the .txt file.

    public void EquipOperation0() {

        userName = UserName.GetComponent<TextMeshProUGUI>().text;
        Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

        form = Lines[0] + Environment.NewLine + Lines[1] + Environment.NewLine + "0" + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6] + Environment.NewLine + Lines[7]; 
        System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);

        defaultProfile.SetActive(true);
        Profile1.SetActive(false);
        Profile2.SetActive(false);
        Profile3.SetActive(false);
        Profile4.SetActive(false);
        Profile5.SetActive(false);
        costumeSprite = costumeImage.GetComponent<Image>().sprite;
        characterSprite = costumeSprite;
        characterImage.GetComponent<Image>().sprite = characterSprite;
    }

    public void EquipOperation1() {

        userName = UserName.GetComponent<TextMeshProUGUI>().text;
        Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

        form = Lines[0] + Environment.NewLine + Lines[1] + Environment.NewLine + "1" + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6] + Environment.NewLine + Lines[7]; 
        System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);

        defaultProfile.SetActive(false);
        Profile1.SetActive(true);
        Profile2.SetActive(false);
        Profile3.SetActive(false);
        Profile4.SetActive(false);
        Profile5.SetActive(false);
        costumeSprite = costumeImage.GetComponent<Image>().sprite;
        characterSprite = costumeSprite;
        characterImage.GetComponent<Image>().sprite = characterSprite;
    }

    public void EquipOperation2() {

        userName = UserName.GetComponent<TextMeshProUGUI>().text;
        Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

        form = Lines[0] + Environment.NewLine + Lines[1] + Environment.NewLine + "2" + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6] + Environment.NewLine + Lines[7];  
        System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);

        defaultProfile.SetActive(false);
        Profile1.SetActive(false);
        Profile2.SetActive(true);
        Profile3.SetActive(false);
        Profile4.SetActive(false);
        Profile5.SetActive(false);
        costumeSprite = costumeImage.GetComponent<Image>().sprite;
        characterSprite = costumeSprite;
        characterImage.GetComponent<Image>().sprite = characterSprite;
    }

    public void EquipOperation3() {

        userName = UserName.GetComponent<TextMeshProUGUI>().text;
        Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

        form = Lines[0] + Environment.NewLine + Lines[1] + Environment.NewLine + "3" + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6] + Environment.NewLine + Lines[7]; 
        System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);

        defaultProfile.SetActive(false);
        Profile1.SetActive(false);
        Profile2.SetActive(false);
        Profile3.SetActive(true);
        Profile4.SetActive(false);
        Profile5.SetActive(false);
        costumeSprite = costumeImage.GetComponent<Image>().sprite;
        characterSprite = costumeSprite;
        characterImage.GetComponent<Image>().sprite = characterSprite;
    }

    public void EquipOperation4() {

        userName = UserName.GetComponent<TextMeshProUGUI>().text;
        Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

        form = Lines[0] + Environment.NewLine + Lines[1] + Environment.NewLine + "4" + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6] + Environment.NewLine + Lines[7]; 
        System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);

        defaultProfile.SetActive(false);
        Profile1.SetActive(false);
        Profile2.SetActive(false);
        Profile3.SetActive(false);
        Profile4.SetActive(true);
        Profile5.SetActive(false);
        costumeSprite = costumeImage.GetComponent<Image>().sprite;
        characterSprite = costumeSprite;
        characterImage.GetComponent<Image>().sprite = characterSprite;
    }

    public void EquipOperation5() {

        userName = UserName.GetComponent<TextMeshProUGUI>().text;
        Lines = System.IO.File.ReadAllLines(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt");

        form = Lines[0] + Environment.NewLine + Lines[1] + Environment.NewLine + "5" + Environment.NewLine + Lines[3] + Environment.NewLine + Lines[4] + Environment.NewLine + Lines[5] + Environment.NewLine + Lines[6] + Environment.NewLine + Lines[7]; 
        System.IO.File.WriteAllText(@"D:/Unity Projects/Sondaj_Bear/Users/"+userName+".txt",form);

        defaultProfile.SetActive(false);
        Profile1.SetActive(false);
        Profile2.SetActive(false);
        Profile3.SetActive(false);
        Profile4.SetActive(false);
        Profile5.SetActive(true);
        costumeSprite = costumeImage.GetComponent<Image>().sprite;
        characterSprite = costumeSprite;
        characterImage.GetComponent<Image>().sprite = characterSprite;
    }
}
