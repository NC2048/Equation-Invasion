using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartScene()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
}


