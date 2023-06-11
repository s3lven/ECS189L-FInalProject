using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public int totalOrders;
    public static int completedOrders;

    // Start is called before the first frame update
    public void CompleteOrder()
    {
        ScoreController.completedOrders += 1;
    }

    public static void Reset()
    {
        completedOrders = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            CompleteOrder();
        }

        string scoreString = string.Format("{0}/{1}", ScoreController.completedOrders, totalOrders);
        scoreText.text = scoreString;

        if (ScoreController.completedOrders == totalOrders)
        {
            SceneManager.LoadScene("End");
        }
    }
}
