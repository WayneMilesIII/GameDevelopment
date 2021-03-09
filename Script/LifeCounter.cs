using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{
   
    public Image[] lives;
    public int livesRemaining;

    // 3 lives: 3 images (0,1,2)
    // 2 lives: 2 images (0,1,[2])
    // 1 lives: 1 images (0,[1],[2])
    // 0 lives: 0 images ([0],[1],[2]) WE LOSE

    public void LoseLife()
    {

        // If there are no lives remaining end
        if (livesRemaining == 0)
            return;
        // decreases the livesRemaining
        livesRemaining--;
        // will hide one of the life image
        lives[livesRemaining].enabled = false;



        // if we run out of life images we lose the game
        if (livesRemaining == 0)
        {
            Debug.Log("You lose");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseLife();
        }
    }
}
