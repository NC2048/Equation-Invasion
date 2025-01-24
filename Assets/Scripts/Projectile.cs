using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public ShootProjectile direction;
    public float speed;
    public float shootDirection;

    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<ShootProjectile>();
        shootDirection = GameObject.FindGameObjectWithTag("Player").transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector3 ((transform.position.x+ speed*shootDirection/Mathf.Abs(shootDirection) * Time.deltaTime),transform.position.y,transform.position.z) ;
        Invoke("DestroyObject", 5);
    }

    public void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "ForceField")
        {
            collision.gameObject.SetActive(false);
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
