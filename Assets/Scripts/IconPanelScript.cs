using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconPanelScript : MonoBehaviour
{
    public Image[] powerUpImgs;
    public Image[] healthImgs;

    public PlayerStats player;
    private int maxHealth; // Maximum health.
    private int health;    // Current health.

    private int numFH = 0;
    private int numSB = 0;
    private int numEH = 0;
    private int numSU = 0;
    private int numIB = 0;

    void Start()
    {
        maxHealth = player.maxHealth;
        health = player.health;

        for(int i = 0; i<5; i++)
        {
            powerUpImgs[i].enabled = false;
        }
    }

    void Update()
    {
        if (numIB > 0)
            powerUpImgs[0].enabled = true;
        else
            powerUpImgs[0].enabled = false;

        if (numEH > 0)
            powerUpImgs[1].enabled = true;
        else
            powerUpImgs[1].enabled = false;
      
        if (numSU > 0)
            powerUpImgs[2].enabled = true;
        else
            powerUpImgs[2].enabled = false;

        if (numSB > 0)
            powerUpImgs[3].enabled = true;
        else
            powerUpImgs[3].enabled = false;

        if (numFH > 0)
            powerUpImgs[4].enabled = true;
        else
            powerUpImgs[4].enabled = false;
    }

    public void UpdateHealthImg()
    {
        health = player.health;

        for (int i = 0; i < maxHealth - 1; i++)
        {
            if (i < health - 1)
            {
                healthImgs[i].enabled = true;
            }
            else
            {
                healthImgs[i].enabled = false;
            }
        }
    }

    public void UpdatePowerUpImg(string name, int val)
    {
        if (name == "FastHook(Clone)")
            numFH += val;
        else if (name == "SpeedUp(Clone)")
            numSU += val;
        else if (name == "ScoreBoost(Clone)")
            numSB += val;
        else if (name == "ExtraHealth(Clone)")
            numEH += val;
        else if (name == "IceBoost(Clone)")
            numIB += val;
    }
}
