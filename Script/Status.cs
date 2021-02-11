using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    // init variables
    public Text healthState, scoreState, ammoState, livesCount;

    public static int playerScore;
    private static int playerHealth;
    public static int playerLives;

    // Update is called once per frame
    void Update()
    {
        playerHealth = Player.health;
        playerLives = Player.lives;
        healthState.text = "HEALTH: " + playerHealth;
        ammoState.text = "AMMO: " + "infinite";
        scoreState.text = "SCORE: " + playerScore;
        livesCount.text = "LIVES: " + playerLives;
    }
    
    public int getScore() {
        return playerScore;
    }
}
