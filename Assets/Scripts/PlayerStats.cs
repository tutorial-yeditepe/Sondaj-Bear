using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public IconPanelScript iconPanel;
    public Sprite[] costumes;
    public GameObject bear;

    public int health;
    public int maxHealth = 4;

    private string playerName;

    [SerializeField] [Range(1.0f, 10.0f)] public float moveSpeed = 5.0f;
    public float scoreBoost = 1;  // Point multiplier.
    [SerializeField] [Range(4.0f, 100.0f)] public float hookSpeed = 4.0f;  // Speed of the hook.

    public int totalPoint = 0;

    private void Start()
    {
        scoreText.text = totalPoint.ToString(); // Initiate score area.
        health = maxHealth;                     // Initialize current health as max health.

        string costume = StaticVariables.costume;
        bear.GetComponent<SpriteRenderer>().sprite = costumes[int.Parse(costume)];
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
