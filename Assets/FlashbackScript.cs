using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class FlashbackScript : MonoBehaviour
{
    private float speech = 1f;
    public GameObject flashbackImage;
    public GameObject continueButton;
    public TMP_Text dialogueText;
    public Sprite attackOfTheSlimes;
    public Sprite stranded;
    public Sprite gems;
    public string level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speech == 1f)
        {
            dialogueText.text = "There once was a peaceful world called Algebra World. The habitants there were squares varying in color from red to purple, but most were a green color. They had harnessed the power of math over billions of years.";
        }

        if (speech == 2f)
        {
            dialogueText.text = "Everything changed when outer space invaders from Slime World arrived for their campaign over the galaxy. Their leader was King Slime. He slaughtered and imprisonned many squares.";
            flashbackImage.GetComponent<SpriteRenderer>().sprite = attackOfTheSlimes;
        }

        if (speech == 3f)
        {
            dialogueText.text = "A young square was stranded away from his family and woke up in a field. He wanted to bring back his planet.";
            flashbackImage.GetComponent<SpriteRenderer>().sprite = stranded;
        }

        if (speech == 4f)
        {
            dialogueText.text = "He knew the planet he was trapped in was in a force field barrier.";
            flashbackImage.GetComponent<SpriteRenderer>().sprite = gems;
        }

        if (speech == 5f)
        {
            dialogueText.text = "To break the barrier, he needed to find the Green Equation Gem, the Blue Algebra Gem, and the Red Operations Gem.";
        }

        if (speech == 6f)
        {
            dialogueText.text = "So he set on his journey to find the gems and defeat King Slime!";
        } 

        if (speech == 7f)
        {
            SceneManager.LoadScene(level);
        }
    }

    public void ContinueButton()
    {
        speech++;
    }
}
