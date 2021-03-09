using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public HealthBar healthBar;

    // init variables
    public Text healthState, scoreState, ammoState, livesCount;

    public static int playerScore;
    private static int playerHealth;
    public static int playerLives;

    // method that will take the damge
    void TakeDamage(int damage)
    {
        playerHealth -= damage;
        // health -= damage;
        healthBar.SetHealth(playerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth = Player.health;
        playerLives = Player.lives;
        healthState.text = "HEALTH: " + playerHealth;
        ammoState.text = "AMMO: " + "infinite";
        scoreState.text = "SCORE: " + playerScore;
        livesCount.text = "LIVES: " + playerLives;
        //TakeDamage(10);
    }

    public static int getScore()
    {
        return playerScore;
    }
}
