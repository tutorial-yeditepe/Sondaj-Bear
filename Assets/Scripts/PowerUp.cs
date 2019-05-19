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

    void Update()
    {
        if(transform.localPosition.y > 300)
        {
            if (name == "SpeedUp")
                StartCoroutine(ApplySpeedUp());
            else if (name == "ScoreBoost")
                StartCoroutine(ApplyScoreBoost());
            else if (name == "FastHook")
                StartCoroutine(ApplyFastHook());
        }
    }

    IEnumerator ApplySpeedUp()
    {
        player.GetComponent<PlayerStats>().moveSpeed *= (float)1.5;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSeconds(5);
        player.GetComponent<PlayerStats>().moveSpeed -= player.GetComponent<PlayerStats>().moveSpeed / 3; // Unapply the powerup.

        Destroy(gameObject);
    }

    IEnumerator ApplyScoreBoost()
    {
        player.GetComponent<PlayerStats>().scoreBoost *= (float)1.1;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSeconds(5);
        player.GetComponent<PlayerStats>().scoreBoost -= player.GetComponent<PlayerStats>().scoreBoost / 11; // Unapply the powerup.

        Destroy(gameObject);
    }

    IEnumerator ApplyFastHook()
    {
        player.GetComponent<PlayerStats>().hookSpeed *= (float)1.5;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSeconds(5);
        player.GetComponent<PlayerStats>().hookSpeed -= player.GetComponent<PlayerStats>().hookSpeed / 3; // Unapply the powerup.

        Destroy(gameObject);
    }
}
