using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Image[] healthHooks;
    public int health;
    private int maxHealth = 4;

    [SerializeField] [Range(1.0f, 10.0f)] public float moveSpeed = 5.0f;
    public float scoreBoost = 1;  // Point multiplier.
    [SerializeField] [Range(4.0f, 100.0f)] public float hookSpeed = 4.0f;  // Speed of the hook.

    public int totalPoint = 0;

    private void Start()
    {
        scoreText.text = totalPoint.ToString();

        health = 3;
    }

    private void Update()
    {
        UpdateHealth();
    }

    public void UpdateScore(float point)
    {
        totalPoint += (int)point;
        scoreText.text = totalPoint.ToString();
    }

    public void UpdateHealth()
    {
        for (int i = 0; i < maxHealth-1; i++)
        {
            if (i < health-1)
            {
                healthHooks[i].enabled = true;
            }
            else
            {
                healthHooks[i].enabled = false;
            }
        }
    }
}
