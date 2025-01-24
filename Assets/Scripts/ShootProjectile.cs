using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter = 0;
    public bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collected = true && throwableCounter > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                offset = new Vector3(transform.localScale.x/Mathf.Abs(transform.localScale.x), 0, 0);
                Vector3 throwablePosition = transform.position + offset;
                Instantiate(objectThrown, throwablePosition, transform.rotation);
                throwableCounter -= 1;
            }
        
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ProjectileFlower")
        {
            collected = true;
            throwableCounter = 10;
            Destroy(collision.gameObject);
        }
    }
}
