using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnees = new GameObject[8];
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
        int spawnY = Random.Range(-110, 110); // A "y" value for our spawn position.

        Vector3 spawnPos = spawnSides[side].transform.position;
        Quaternion spawnRot = spawnSides[side].transform.rotation;

        spawnPos += new Vector3(0, spawnY, 0); // Changing the spawn position.
        
        Transform t = ((GameObject)Instantiate(spawnees[prefab], spawnPos, spawnRot, spawnSides[side].transform)).transform;
        //t.SetParent(spawnSides[side].transform, false);

        if (side == 0)
        {
            Vector3 reverse = t.localScale;
            reverse.x = reverse.x * -1;
            t.localScale = reverse;
        }
    }
}
