using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Sike!!! You think you're smart, you fell for the bait!'");
        }
    }
}
