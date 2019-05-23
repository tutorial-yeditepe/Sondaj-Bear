using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public void pauseTheGame() {

        Time.timeScale = 0;
    }
    public void continueTheGame() {

        Time.timeScale = 1;
    }
}
