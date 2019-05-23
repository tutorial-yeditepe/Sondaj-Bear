using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    private PlayerStats player;
    private Image img;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();

        img = transform.parent.GetComponentInChildren<Image>();

        Debug.Log(img);
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
        player.moveSpeed *= (float)1.5;

        GetComponent<BoxCollider2D>().enabled = false;

        transform.position = new Vector3(1000, 1000, 0);

        player.UpdatePowerUp(name, 1);
        yield return new WaitForSeconds(5);
        player.moveSpeed -= player.moveSpeed / 3; // Unapply the powerup.
        player.UpdatePowerUp(name, -1);

        Destroy(gameObject);
    }

    IEnumerator ScoreBoost()
    {
        player.scoreBoost *= (float)1.5;

        GetComponent<BoxCollider2D>().enabled = false;

        transform.position = new Vector3(1000, 1000, 0);

        player.UpdatePowerUp(name, 1);
        yield return new WaitForSeconds(5);
        player.scoreBoost -= player.scoreBoost / 11; // Unapply the powerup.
        player.UpdatePowerUp(name, -1);

        Destroy(gameObject);
    }

    IEnumerator FastHook()
    {
        player.hookSpeed *= (float)1.5;

        GetComponent<BoxCollider2D>().enabled = false;

        transform.position = new Vector3(1000, 1000, 0);

        player.UpdatePowerUp(name, 1);
        yield return new WaitForSecondsRealtime(5);
        player.hookSpeed -= player.hookSpeed / 3; // Unapply the powerup.
        player.UpdatePowerUp(name, -1);

        Destroy(gameObject);
    }
}
