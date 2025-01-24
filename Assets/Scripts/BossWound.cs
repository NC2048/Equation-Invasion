using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWound : MonoBehaviour
{
    public GameObject player;
    public GameObject boss;
    public Sprite WoundedBoss1;
    public Sprite WoundedBoss2;
    public Sprite DeadBoss;
    public bool dead = false;
    public BossController controller;
    public bool hitEnemy = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (controller.hitsTaken == 0&& hitEnemy == true)
            {
                boss.GetComponent<SpriteRenderer>().sprite = WoundedBoss1;
                controller.hitsTaken++;
                hitEnemy = false;
                Invoke("HitEnemy", 5);
            }

            if (controller.hitsTaken == 1 && hitEnemy == true) 
            {
                boss.GetComponent<SpriteRenderer>().sprite = WoundedBoss2;
                controller.hitsTaken++;
                hitEnemy = false;
                Invoke("HitEnemy", 5);
            }

            if (controller.hitsTaken == 2 && hitEnemy == true)
            {
                boss.GetComponent<SpriteRenderer>().sprite = DeadBoss;
                controller.hitsTaken++;
            }

        }
    }


    private void HitEnemy()
    {
        hitEnemy = true;
    }
}
