using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public Text pointsText;
    
    public void Setup(int score) {
        gameObject.SetActive(true);
        pointsText.text = "Score: " + score.ToString() + " Points";
    }

    public void restartButton() {
        SceneManager.LoadScene("SampleScene");
    }

    public void menuButton() {
        SceneManager.LoadScene("Start Menu");
    }
}
