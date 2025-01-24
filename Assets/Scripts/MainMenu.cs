using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Equation Invasion Level 1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Equation Invasion Level 2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Equation Invasion Level 3");
    }

    public void BossBattleEntrance()
    {
        SceneManager.LoadScene("Boss Battle Entrance");
    }

    public void BossFight()
    { 
        SceneManager.LoadScene("Boss Fight");
    }

}
