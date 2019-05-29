using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    private PlayerStats player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
    }

    public void ApplyPowerUp(string name) {

        if (name == "SpeedUp(Clone)")
            StartCoroutine(SpeedUp());
        else if (name == "ScoreBoost(Clone)")
            StartCoroutine(ScoreBoost());
        else if (name == "FastHook(Clone)")
            StartCoroutine(FastHook());
        else if (name == "ExtraHealth(Clone)")
            StartCoroutine(ExtraHealth());
        else if (name == "IceBoost(Clone)")
            StartCoroutine(ExtraHealth());
    }

    IEnumerator SpeedUp()
    {
        player.moveSpeed *= (float)1.5;

        GetComponent<BoxCollider2D>().enabled = false;

        transform.position = new Vector3(1000, 1000, 0); // A bad way to get power up of our sight.
                                                         // Somehow disabling the image creates a bug.

        player.UpdatePowerUp(name, 1);            // 1 = Enable power up.
        yield return new WaitForSeconds(5);
        player.moveSpeed -= player.moveSpeed / 3; // Unapply the powerup.
        player.UpdatePowerUp(name, -1);           // -1 = Disable power up.s

        Destroy(gameObject);
    }

    IEnumerator ScoreBoost()
    {
        player.scoreBoost *= (float)2;

        GetComponent<BoxCollider2D>().enabled = false;

        transform.position = new Vector3(1000, 1000, 0); // A bad way to get power up of our sight.
                                                         // Somehow disabling the image creates a bug.

        player.UpdatePowerUp(name, 1);   // 1 = Enable power up.
        yield return new WaitForSeconds(5);
        player.scoreBoost = player.scoreBoost / 2; // Unapply the powerup.
        player.UpdatePowerUp(name, -1);  // -1 = Disable power up.

        Destroy(gameObject);
    }

    IEnumerator FastHook()
    {
        player.hookSpeed *= (float)1.5;

        GetComponent<BoxCollider2D>().enabled = false;

        transform.position = new Vector3(1000, 1000, 0); // A bad way to get power up of our sight.
                                                         // Somehow disabling the image creates a bug.

        player.UpdatePowerUp(name, 1);            // 1 = Enable power up.
        yield return new WaitForSecondsRealtime(5);
        player.hookSpeed -= player.hookSpeed / 3; // Unapply the powerup.
        player.UpdatePowerUp(name, -1);           // -1 = Disable power up.

        Destroy(gameObject);
    }

    IEnumerator ExtraHealth()
    {
        GetComponent<BoxCollider2D>().enabled = false;

        transform.position = new Vector3(1000, 1000, 0); // A bad way to get power up of our sight.
                                                         // Somehow disabling the image creates a bug.

        if (player.health < player.maxHealth)
            player.UpdateHealth(1);

        player.UpdatePowerUp(name, 1);            // 1 = Enable power up.
        yield return new WaitForSecondsRealtime(1);
        player.UpdatePowerUp(name, -1);           // -1 = Disable power up.

        Destroy(gameObject);
    }

    IEnumerator IceBoost()
    {
        GetComponent<BoxCollider2D>().enabled = false;

        transform.position = new Vector3(1000, 1000, 0); // A bad way to get power up of our sight.
                                                         // Somehow disabling the image creates a bug.

        player.platform.GetComponent<PlatformMelt>().IncreaseSize(6);

        player.UpdatePowerUp(name, 1);            // 1 = Enable power up.
        yield return new WaitForSecondsRealtime(1);
        player.UpdatePowerUp(name, -1);           // -1 = Disable power up.

        Destroy(gameObject);
    }
}
