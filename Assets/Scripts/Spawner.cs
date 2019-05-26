using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnees = new GameObject[1];
    public GameObject[] spawnSides = new GameObject[2];

    private float spawnTime = 1;
    private float spawnDelay = (float)1.5;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    void SpawnObject()
    {
        int prefab = Random.Range(0, spawnees.Length); // Index number for selecting a prefab.
        int side = Random.Range(0, spawnSides.Length); // Index number for selecting a spawn side (0 = left, 1 = right).
        int spawnY = Random.Range(20, ((Screen.height * 50) / 100)); // A "y" value for our spawn position.

        Vector2 spawnPos = spawnSides[side].transform.localPosition;
        Quaternion spawnRot = spawnSides[side].transform.rotation;

        spawnPos += new Vector2(0, spawnY); // Changing the spawn position.
        
        Transform t = ((GameObject)Instantiate(spawnees[prefab], spawnPos, spawnRot, spawnSides[side].transform)).transform;
        //t.SetParent(spawnSides[side].transform, false);

        if (side == 0 && spawnees[prefab].tag != "PowerUp")
        {
            Vector3 reverse = t.localScale;
            reverse.x = reverse.x * -1;
            t.localScale = reverse;
        }
    }
}
