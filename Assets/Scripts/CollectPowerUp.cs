using UnityEngine;

public class CollectPowerUp : MonoBehaviour
{
    public GameObject player;
    public PlayerMovement characteristics;
    public bool meat = false;
    public bool hasOpened = false;
    public bool flower = false;
    public AudioSource meatSource;
    public AudioClip chomp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "PowerMeat")
        {
            characteristics.speed = 7f;
            characteristics.jumpSpeed = 9f;
            player.transform.localScale = new Vector2(12f, 12f);
            meat = true;
            collision.gameObject.SetActive(false);
            Invoke("LosePower", 10f);
            meatSource.PlayOneShot(chomp);
        }

        if(collision.gameObject.tag == "Projectile Flower")
        {

        }
    }

    void LosePower()
    {
        characteristics.speed = 5f;
        characteristics.jumpSpeed = 7f;
        player.transform.localScale = new Vector2(6f, 6f);
        meat = false;
    }
}
