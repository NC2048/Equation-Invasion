using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinalExit : MonoBehaviour
{
    SpriteRenderer m_renderer;
    public GameObject background;
    public GemChecker gem;
    public TMP_Text  gemText;
    public GameObject gemPanel;
    public string teleportDestination;

    private void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && gem.green == false && gem.blue == false && gem.red == false)
        {
            gemPanel.SetActive(true);
            gemText.text = "You must find the green gem in Trial 1, the blue gem in Trial 2, and the red gem in Trial 3.";
        }

        if (col.gameObject.tag == "Player" && gem.green == true && gem.blue == false && gem.red == false)
        {
            gemPanel.SetActive(true);
            gemText.text = "You must find the blue gem in Trial 2 and the red gem in Trial 3.";
        }

        if (col.gameObject.tag == "Player" && gem.blue == true && gem.red == false && gem.green == false)
        {
            gemPanel.SetActive(true);
            gemText.text = "You must find the green gem in Trial 1 and the red gem in Trial 3.";
        }

        if (col.gameObject.tag == "Player" && gem.red == true && gem.green == false && gem.blue == false)
        {
            gemPanel.SetActive(true);
            gemText.text = "You must find the green gem in Trial 1 and the blue gem in Trial 2.";
        }

        if (col.gameObject.tag == "Player" && gem.green == true && gem.blue == true && gem.red == false)
        {
            gemPanel.SetActive(true);
            gemText.text = "You must find the red gem in Trial 3.";
        }

        if (col.gameObject.tag == "Player" && gem.green == true && gem.red == true && gem.blue == false)
        {
            gemPanel.SetActive(true);
            gemText.text = "You must find the blue gem in Trial 2.";
        }

        if (col.gameObject.tag == "Player" && gem.blue == true && gem.red == true && gem.green == false)
        {
            gemPanel.SetActive(true);
            gemText.text = "You must find the green gem in Trial 1.";
        }

        if(col.gameObject.tag == "Player" && gem.green == true && gem.blue == true && gem.red == true)
        {
            SceneManager.LoadScene(teleportDestination);
        }

    }
}
