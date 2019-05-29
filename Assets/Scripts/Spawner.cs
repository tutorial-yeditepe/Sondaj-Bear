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
        int pIndex = Random.Range(0, spawnees.Length); // Index number for selecting a prefab.
        int side = Random.Range(0, spawnSides.Length); // Index number for selecting a spawn side (0 = left, 1 = right).

        int min = (int)Camera.main.ViewportToWorldPoint(new Vector2(0f, 0.50f)).y;
        int max = (int)Camera.main.ViewportToWorldPoint(new Vector2(0f, 0.019f)).y;

        // int spawnY = Random.Range(20, ((Screen.height * 45) / 100)); // A "y" value for our spawn position.
        int spawnY = Random.Range(min, max); // A "y" value for our spawn position.

        Vector2 spawnPos = spawnSides[side].transform.position;
        Quaternion spawnRot = spawnSides[side].transform.rotation;

        spawnPos = new Vector2(spawnPos.x, spawnY); // Changing the spawn position.

        //Transform t = ((GameObject)Instantiate(spawnees[pIndex], spawnPos, spawnRot, spawnSides[side].transform)).transform;
        //t.SetParent(spawnSides[side].transform, false);

        GameObject obj = Instantiate(spawnees[pIndex], spawnPos, spawnRot, spawnSides[side].transform);

        /*if (side == 0 && spawnees[pIndex].tag != "PowerUp")
        {
            Vector3 reverse = t.localScale;
            reverse.x = reverse.x * -1;
            t.localScale = reverse;
        }*/

        if (side == 0 && spawnees[pIndex].tag != "PowerUp")
        {
            Vector3 reverse = obj.transform.localScale;
            reverse.x = reverse.x * -1;
            obj.transform.localScale = reverse;
        }
    }
}
