using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] [Range(1.0f, 10.0f)] public float moveSpeed = 5.0f;
    public float scoreBoost = 1;  // Point multiplier.
    [SerializeField] [Range(4.0f, 100.0f)] public float hookSpeed = 4.0f;  // Speed of the hook.

    public float totalPoint = 0;
}
