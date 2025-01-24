using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Exit : MonoBehaviour
{
    SpriteRenderer m_renderer;
    public GameObject background;
    public string teleportDestination;

    private void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(teleportDestination);
        }

    }
}
