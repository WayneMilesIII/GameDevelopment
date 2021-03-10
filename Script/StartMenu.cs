using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // method for the Start Game Button
    public void startGame()
    {
        // loads the scene for gameplay
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PauseMenu.GameIsPaused = false;
        SceneManager.LoadScene(1);

    }

    // method for the Quit Game Button
    public void quitGame()
    {
        Application.Quit();
    }

}
