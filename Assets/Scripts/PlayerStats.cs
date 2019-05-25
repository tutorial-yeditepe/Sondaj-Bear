using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
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

    [SerializeField] [Range(1.0f, 10.0f)] public float moveSpeed = 5.0f;
    public float scoreBoost = 1;  // Point multiplier.
    [SerializeField] [Range(4.0f, 100.0f)] public float hookSpeed = 4.0f;  // Speed of the hook.

    private void Start()
    {
        scoreText.text = totalPoint.ToString(); // Initialize score text.

        coins = float.Parse(StaticVariables.coins);
        coinText.text = coins.ToString();       // Initialize coin text.

        health = maxHealth;                     // Initialize current health as max health.

        string costume = StaticVariables.costume;
        bear.GetComponent<SpriteRenderer>().sprite = costumes[int.Parse(costume)];
        
        totalFish = int.Parse(StaticVariables.numberOfFish);
    }

    public void UpdateCoins(float coin)
    {
        coins += coin;
        coinText.text = coins.ToString();
    }

    public void UpdateFishCount()
    {
        totalFish++;
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
    }

    public void UpdatePowerUp(string name, int val)
    {
        iconPanel.UpdatePowerUpImg(name, val);  // Which power up and if we are enabling or disabling the powerup.
    }
}
