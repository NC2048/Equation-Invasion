using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemChecker : MonoBehaviour
{
    public bool green = false;
    public bool blue = false;
    public bool red = false;
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
        if (col.gameObject.tag == "Green")
        {
            green = true;
        }

        if (col.gameObject.tag == "Blue")
        {
            blue = true;
        }

        if (col.gameObject.tag == "Red")
        {
            red = true;
        }
    }
}
