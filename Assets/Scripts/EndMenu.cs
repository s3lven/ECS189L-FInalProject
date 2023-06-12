using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    public void GoToHome()
    {
        SceneManager.LoadScene("Title");
    }

    public void RestartGame()
    {
        ScoreController.Reset();
        SceneManager.LoadScene("MainScene");
    }
}
