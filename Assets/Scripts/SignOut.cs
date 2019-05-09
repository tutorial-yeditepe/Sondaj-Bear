using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

public class SignOut : MonoBehaviour
{

    public GameObject signOutPanel;
    public GameObject userPagePanel;
    public GameObject usernamePanel;
    public GameObject usernameText;
    public GameObject userProfilePicture;
    public GameObject guestPicture;
    public GameObject playAsUserButton;
    public GameObject playAsGuestButton;
    public GameObject loginButton;
    public GameObject signUpButton;

    public void SignOutOperation() {

        signOutPanel.SetActive(false);
        userPagePanel.SetActive(false);
        usernamePanel.SetActive(false);
        usernameText.GetComponent<TextMeshProUGUI>().text = "null";
        userProfilePicture.SetActive(false);
        guestPicture.SetActive(true);
        playAsUserButton.SetActive(false);
        playAsGuestButton.SetActive(true);
        loginButton.SetActive(true);
        signUpButton.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
