using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

public class HighScores : MonoBehaviour
{

    public GameObject FirstPlace;
    public GameObject SecondPlace;
    public GameObject ThirdPlace;
    public GameObject FourthPlace;
    public GameObject FifthPlace;
    public GameObject FirstPlaceScore;
    public GameObject SecondPlaceScore;
    public GameObject ThirdPlaceScore;
    public GameObject FourthPlaceScore;
    public GameObject FifthPlaceScore;

    public GameObject PlayerStats;

    private String[] Lines;
    private string form;

    public void updateHighscores() {


    }


    // Start is called before the first frame update
    void Start()
    {
        if(System.IO.File.Exists(Application.persistentDataPath+"/highscores.txt")) {        //Check if highscores.txt exists.

            Lines = System.IO.File.ReadAllLines(Application.persistentDataPath+"/highscores.txt");
            if(Lines[0] != "--") {
                FirstPlace.GetComponent<TextMeshProUGUI>().text = "1) "+ Lines[0];
                FirstPlaceScore.GetComponent<TextMeshProUGUI>().text = Lines[1];
            }else {
                FirstPlace.GetComponent<TextMeshProUGUI>().text = "--";
                FirstPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            }

            if(Lines[2] != "--") {
                SecondPlace.GetComponent<TextMeshProUGUI>().text = "2) "+ Lines[2];
                SecondPlaceScore.GetComponent<TextMeshProUGUI>().text = Lines[3];
            }else {
                SecondPlace.GetComponent<TextMeshProUGUI>().text = "--";
                SecondPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            }

            if(Lines[4] != "--") {
                ThirdPlace.GetComponent<TextMeshProUGUI>().text = "3) "+ Lines[4];
                ThirdPlaceScore.GetComponent<TextMeshProUGUI>().text = Lines[5];
            }else {
                ThirdPlace.GetComponent<TextMeshProUGUI>().text = "--";
                ThirdPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            }

            if(Lines[6] != "--") {
                FourthPlace.GetComponent<TextMeshProUGUI>().text = "4) "+ Lines[6];
                FourthPlaceScore.GetComponent<TextMeshProUGUI>().text = Lines[7];
            }else {
                FourthPlace.GetComponent<TextMeshProUGUI>().text = "--";
                FourthPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            }

            if(Lines[8] != "--") {
                FifthPlace.GetComponent<TextMeshProUGUI>().text = "5) "+ Lines[8];
                FifthPlaceScore.GetComponent<TextMeshProUGUI>().text = Lines[9];
            }else {
                FifthPlace.GetComponent<TextMeshProUGUI>().text = "--";
                FifthPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            }
                
        }else {
            
            form = "--"  + Environment.NewLine + "--"  + Environment.NewLine + "--"  + Environment.NewLine + "--"  + Environment.NewLine + "--" + Environment.NewLine + "--"  + Environment.NewLine + "--"  + Environment.NewLine + "--"  + Environment.NewLine + "--";
            System.IO.File.WriteAllText(Application.persistentDataPath+"/highscores.txt",form);

            FirstPlace.GetComponent<TextMeshProUGUI>().text = "--";
            FirstPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            SecondPlace.GetComponent<TextMeshProUGUI>().text = "--";
            SecondPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            ThirdPlace.GetComponent<TextMeshProUGUI>().text = "--";
            ThirdPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            FourthPlace.GetComponent<TextMeshProUGUI>().text = "--";
            FourthPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            FifthPlace.GetComponent<TextMeshProUGUI>().text = "--";
            FifthPlaceScore.GetComponent<TextMeshProUGUI>().text = "--";
            
        }
        
    }

}
