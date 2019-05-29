using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public GameObject trophyPanel;
    public GameObject gameOverPanel;
    public GameObject platform;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;

    public IconPanelScript iconPanel;
    public Sprite[] costumes;
    public GameObject bear;
    
    public int health;
    public int maxHealth = 4;

    private string playerName;
    public float coins;
    public int totalPoint = 0;
    public int totalFish;

    public string trophy1; // Caught 10 fish.
    public string trophy2; // Caught 100 fish.
    public string trophy3; // Caught 1000 fish.

    [SerializeField] [Range(1.0f, 10.0f)] public float moveSpeed = 5.0f;
    public float scoreBoost = 1;  // Point multiplier.
    [SerializeField] [Range(4.0f, 100.0f)] public float hookSpeed = 4.0f;  // Speed of the hook.

    private void Start()
    {
        scoreText.text = totalPoint.ToString(); // Initialize score text.

        coins = float.Parse(StaticVariables.coins);
        coinText.text = coins.ToString();       // Initialize coin text.

        health = maxHealth;                     // Initialize current health as max health.

        string costume = StaticVariables.costume;     // Get the right costume for our player
        bear.GetComponent<SpriteRenderer>().sprite = costumes[int.Parse(costume)];
        
        totalFish = int.Parse(StaticVariables.numberOfFish);   // Keep counting fishes.

        trophy1 = StaticVariables.trophy1; // User's trophy records.
        trophy2 = StaticVariables.trophy2;
        trophy3 = StaticVariables.trophy3;
    }

    public void UpdateCoins(float coin)
    {
        coins += coin;
        coinText.text = coins.ToString();
    }

    public void UpdateFishCount()
    {
        totalFish++;
        
        if(totalFish >= 1000 && trophy3 != "1")
        {
            trophy3 = "1";
            StartCoroutine(TrophyPanel());
        }
        else if (totalFish >= 100 && trophy2 != "1")
        {
            trophy2 = "1";
            StartCoroutine(TrophyPanel());
        }
        else if (totalFish >= 10 && trophy1 != "1")
        {
            trophy1 = "1";
            StartCoroutine(TrophyPanel());
        }
    }

    IEnumerator TrophyPanel()
    {
        trophyPanel.SetActive(true);
        yield return new WaitForSeconds(5);
        trophyPanel.SetActive(false);
    }

    public void UpdateScore(float point)
    {
        totalPoint += (int)point;
        scoreText.text = totalPoint.ToString();
    }

    public void UpdateHealth(int change)
    {
        health += change;
        iconPanel.UpdateHealthImg();

        if(health == 0)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void PlatformMelted()
    {
        gameOverPanel.SetActive(true);
    }

    public void UpdatePowerUp(string name, int val)
    {
        iconPanel.UpdatePowerUpImg(name, val);  // Which power up and if we are enabling or disabling the powerup.
    }
}
