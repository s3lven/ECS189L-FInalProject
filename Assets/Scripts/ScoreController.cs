using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public static void Reset()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        string scoreString = string.Format("{0}", OrderController.score);
        scoreText.text = scoreString;

        // Condition to load the end screen
        // if (ScoreController.completedOrders == totalOrders)
        // {
        //     SceneManager.LoadScene("End");
        // }
    }
}
