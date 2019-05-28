using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour
{
    public Sprite[] backgrounds = new Sprite[1];
    private Image image;
    private PlayerStats player;
    private int counter = 1;

    private void Start()
    {
        player = GameObject.Find("Bear And Platform").GetComponent<PlayerStats>();
        image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.totalPoint >= 50 * counter)
        {
            int number = Random.Range(0,backgrounds.Length); // random background number
            Sprite new_image = backgrounds[number]; // take the new background
            backgrounds[number] = image.sprite; // save the old background
            image.sprite = new_image; // change the background
            counter++;
        }
    }
}
