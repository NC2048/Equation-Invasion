using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject stopMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Equation Invasion Level 1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Resume()
    {
        stopMenu.SetActive(false);
    }

    public void Pause()
    {
        stopMenu.SetActive(true);
    }
}
