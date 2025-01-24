using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuideInteract : MonoBehaviour
{
    public int guide;
    public TMP_Text guideText;
    public GameObject guidePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(guide == 1)
        {
            guideText.text = "To defeat an enemy/slime, make sure to jump onto their head.";
        }

        if(guide == 2)
        {
            guideText.text = "Hint: Answer a question to get the double jump; hit the very middle box of the bottom row to get Power Meat, combined with the Double Jump, jump to the top and hit the top box to get the gem.";
        }

        if(guide == 3)
        {
            guideText.text = "Use the projectiles to destroy the force field.";
        }

        if(guide == 4)
        {
            guideText.text = "Hint: Use your wall jumping skills to jump up to the top, continue to use it to get to the very top.";
        }

        if(guide == 5)
        {
            guideText.text = "Take the box in the middle, wall jump up, destroy the enemy and force field, take the big jump left to a island with the real portal. May have to use power meat twice, box has unlimited supply. ";
        }

        if(guide == 6)
        {
            guideText.text = "Get ready for the boss! Hint: let the boss fall onto you, the weak spot is on the bottom of King Slime.";
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "guide1")
        {
            guide = 1;
            guidePanel.SetActive(true);
        }

        if (col.gameObject.tag == "guide2")
        {
            guide = 2;
            guidePanel.SetActive(true);
        }

        if (col.gameObject.tag == "guide3")
        {
            guide = 3;
            guidePanel.SetActive(true);
        }

        if (col.gameObject.tag == "guide4")
        {
            guide = 4;
            guidePanel.SetActive(true);
        }

        if (col.gameObject.tag == "guide5")
        {
            guide = 5;
            guidePanel.SetActive(true);
        }

        if (col.gameObject.tag == "guide6")
        {
            guide = 6;
            guidePanel.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        guidePanel.SetActive(false);
    }
}
