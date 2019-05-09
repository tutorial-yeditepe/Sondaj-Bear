using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private PlayerStats player;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            player = col.gameObject.GetComponent<PlayerStats>();

            if (name == "SpeedUp")
                StartCoroutine( ApplySpeedUp() );
            else if (name == "ScoreBoost")
                StartCoroutine( ApplyScoreBoost() );
            else if (name == "FastHook")
                StartCoroutine( ApplyFastHook() );
        }
    }

    IEnumerator ApplySpeedUp()
    {
        player.moveSpeed *= (float)1.5;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSeconds(5);
        player.moveSpeed -= player.moveSpeed / 3; // Unapply the powerup.

        Destroy(gameObject);
    }

    IEnumerator ApplyScoreBoost()
    {
        player.scoreBoost *= (float)1.1;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSeconds(5);
        player.scoreBoost -= player.scoreBoost / 11; // Unapply the powerup.

        Destroy(gameObject);
    }

    IEnumerator ApplyFastHook()
    {
        player.hookSpeed *= (float)1.5;

        transform.position = new Vector3(-1000, -1000, -1000); // Get it out of our sight.
        yield return new WaitForSeconds(5);
        player.hookSpeed -= player.hookSpeed / 3; // Unapply the powerup.

        Destroy(gameObject);
    }
}
