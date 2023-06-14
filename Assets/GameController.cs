using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI drinksMadeText;
    public TMPro.TextMeshProUGUI drinksFailedText;

    // Start is called before the first frame update
    void Start()
    {
        string scoreString = string.Format("{0}", OrderController.score);
        string drinksMadeString = string.Format("{0}", OrderController.drinksMade);
        string drinksFailedString = string.Format("{0}", OrderController.drinksFailed);

        scoreText.text = scoreString;
        drinksMadeText.text = drinksMadeString;
        drinksFailedText.text = drinksFailedString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
