using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*
     * References
     */
    //Reference to scene camera
    public Camera cam;
    //Reference to rigidbody of player
    public Rigidbody2D rb;
    //Reference to projectile spawn location on player
    public Transform Projectile_Spawner;
    //Reference to projectile template for projectile spawning
    public GameObject projTemplate;
    //Reference the spawn point
    public Transform spawnPoint;


    /*
     * Variables
     */
    //Variable to manage player movement speed
    public float moveSpeed = 5f;
    //Variable to manage player projectile force
    public float projForce = 20f;
    //Variable for player health
    public static int health;
    //Variable for player lives
    public static int lives;
    //Boolean for player death
    public static bool isDead;

    /*
     * Other
     */
    //Vectors to manage player aiming and movement
    Vector2 movement;
    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        lives = 5;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        PlayerDeathCheck();

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetKeyDown("escape")) 
        {
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 aimDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projTemplate, Projectile_Spawner.position, Projectile_Spawner.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(Projectile_Spawner.up * projForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag.Equals("Enemy")) 
        {
            health -= 10;
            //DO SOMETHING TO MOVE ENEMY AWAY FROM PLAYER AFTER CONTACT
        }
    }

    void PlayerDeathCheck() 
    {
        if (health <= 0) 
        {
            isDead = true;
            health += 100;
            lives -= 1;
        }

        if (isDead) 
        {
            isDead = false;
            transform.position = spawnPoint.position; 
        }
    }
}
