using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Collections.Specialized;

public class BossController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float speed = 3f;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float projectileForce = 20f;
    public float projectileCooldown = 2f;
    public int requiredHitsToDefeat = 3;
    public PlayerMovement p;
    public bool GroundPoundInAir = false;
    public GameObject bossDialogueBox;
    public GameObject TempWall;
    public int attack;
    public AudioSource beepSource;
    public AudioClip beep;
    public AudioSource musicSource;
    public AudioClip dragonCastle;
    public AudioSource noSource;
    public AudioClip revenge;
    public Sprite Player;
    public Sprite DeadPlayer;
    public bool bossDead = false;
    public GameObject boss;
    public GameObject winMenu;

    private Rigidbody2D rb;
    private bool isGrounded = true;
    public float hitsTaken = 0;
    private float projectileTimer = 0f;
    public float speech = 0f;
    public TMP_Text dialogueText;
    public GameObject player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speech = 1f;
    }

    private void Update()
    {
        if (speech == 1f)
        {
            dialogueText.text = "I guess you've finally arrived here to liberate your negligible small world from me.";
        }

        if (speech == 2f)
        {
            dialogueText.text = "Well, you've totally came at the worst time possible. My power is at its full extent. There is no escaping this time.";
        }

        if (speech == 3f)
        {
            dialogueText.text = "There is no chance of you stopping me now. After consuming lots of Power Meat and Projectile Flowers, you are doomed.";
        }

        if (speech == 4f)
        {
            dialogueText.text = "Now with my full power, I will destroy your pathetic world and its inhabitants and expand my glorious kingdom.";
        }

        if (speech == 5f)
        {
            dialogueText.text = "I, King Slime I, will conquer the solar system!";
        }

        if (speech == 6f)
        {
            dialogueText.text = "Mwuhahahahahaha!!!!!!";
        }

        if (speech == 7f)
        {
            musicSource.PlayOneShot(dragonCastle);
            TempWall.SetActive(false);
            speech++;
        }
        if (speech >= 8f)
        {
            int attack = UnityEngine.Random.Range(0, 5);
            //Jumping
            if (attack == 0f)
            {
                if (isGrounded)
                {
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                    isGrounded = false;
                    Invoke("Ground", 2f);
                    speech++;
                }
            }

            // Shooting projectiles
            if (attack == 1f)
            {
                projectileTimer += Time.deltaTime;
                if (projectileTimer >= projectileCooldown)
                {
                    ShootProjectile();
                    projectileTimer = 0f;
                    speech++;
                }
            }

            // Ground pounding
            if (attack == 2f)
            {
                if (isGrounded)
                {
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                    isGrounded = false;
                    Invoke("Ground", 2f);
                    if (isGrounded && p.isTouchingGround)
                    {
                        player.GetComponent<SpriteRenderer>().sprite = DeadPlayer;
                        Invoke("helpStunnedPlayer", 5f);
                    }
                    speech++;
                }
                // Implement ground pounding logic here


                // Defeat condition
                if (hitsTaken == requiredHitsToDefeat)
                {
                    dialogueText.text = "No! After all this time! And I fell to a small shape who defeated me!";
                    if (speech >= 9f)
                    {
                        dialogueText.text = "Nwo nwooooo nwooo nooooooooooooooo!!!!!!!";
                        noSource.PlayOneShot(revenge);
                        Invoke("bossSlain", 6f);
                        winMenu.SetActive(true);
                    }

                }
            }

            if (attack == 3f)
            {
                if (transform.position.x <= -7.5)
                {
                    speed = speed * -1;
                    transform.localScale = new Vector2(-5.98175f, 5.980824f);
                }
                if (transform.position.x >= 8)
                {
                    speed = speed * -1;
                    transform.localScale = new Vector2(5.98175f, 5.980824f);
                }
                float newXPosition = transform.position.x + speed * Time.deltaTime;
                float newYPosition = transform.position.y;
                Vector2 newPosition = new Vector2(newXPosition, newYPosition);
                transform.position = newPosition;
            }
        }

    }

        private void ShootProjectile()
        {
            GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
            Rigidbody2D projectileRB = projectile.GetComponent<Rigidbody2D>();
            projectileRB.AddForce(Vector2.left * projectileForce, ForceMode2D.Impulse);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ground")
            {
                isGrounded = true;
            }

            if (collision.gameObject.tag == "Player")
            {
                p.lives -= 0.5f;
            }
        }

        public void Continue()
        {
            speech += 1;
            beepSource.PlayOneShot(beep);
        }

        public void Ground()
        {
            isGrounded = true;
        }

        public void helpStunnedPlayer()
        {
            player.GetComponent<SpriteRenderer>().sprite = Player;
        }

    public void bossSlain()
    {
        boss.SetActive(false);
    }
}
