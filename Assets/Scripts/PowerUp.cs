using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void ApplyPowerUp(string name) {

        if (name == "SpeedUp(Clone)")
            StartCoroutine(SpeedUp());
        else if (name == "ScoreBoost(Clone)")
            StartCoroutine(ScoreBoost());
        else if (name == "FastHook(Clone)")
            StartCoroutine(FastHook());
    }

    IEnumerator SpeedUp()
    {
        player.GetComponent<PlayerStats>().moveSpeed *= (float)1.5;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSeconds(5);
        player.GetComponent<PlayerStats>().moveSpeed -= player.GetComponent<PlayerStats>().moveSpeed / 3; // Unapply the powerup.

        Destroy(gameObject);
    }

    IEnumerator ScoreBoost()
    {
        player.GetComponent<PlayerStats>().scoreBoost *= (float)1.5;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSeconds(5);
     
        player.GetComponent<PlayerStats>().scoreBoost -= player.GetComponent<PlayerStats>().scoreBoost / 11; // Unapply the powerup.
        
        Destroy(gameObject);
    }

    IEnumerator FastHook()
    {
        player.GetComponent<PlayerStats>().hookSpeed *= (float)1.5;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSecondsRealtime(5);
        player.GetComponent<PlayerStats>().hookSpeed -= player.GetComponent<PlayerStats>().hookSpeed / 3; // Unapply the powerup.

        Destroy(gameObject);
    }
}
