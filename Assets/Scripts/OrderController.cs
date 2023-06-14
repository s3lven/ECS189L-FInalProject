using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Boba;

public class OrderController : MonoBehaviour
{
    [SerializeField] DrinkController drinkController;
    private string order;
    private string drink;
    public int points = 10;
    public static int drinksFailed;
    public static int drinksMade;
    public static int score;

    public TeaTypes orderTea;
    public ToppingsType orderToppings;
    public SyrupPowderType orderSugar;
    public SyrupPowderType orderMilk;
    public bool orderIce;
    public bool orderShaked;
    public bool orderBlended;

    public void checkEncoding()
    {
        drink = drinkController.EncodeDrink();

        if (order == drink)
        {
            // Pass! Play a sound signifies a correct order
            Debug.Log("Passed!");
            // Run code to add points and reproduce a new recipe
            createOrderEncoding();
            // Zero the DrinkController
            drinkController.TrashDrink();
            drinksMade++;
            score += points;
        }
        else
        {
            Debug.Log("Failed!");
            drinkController.TrashDrink();
            drinksFailed++;
            score -= points;
            createOrderEncoding();
        }

        Debug.Log("Number of Drinks Made: " + drinksMade);
        Debug.Log("Number of Drinks Failed: " + drinksFailed);
        Debug.Log("Score: " + score);
    }

    void createOrderEncoding()
    {
        var randomGen = new System.Random();
        // randomMilk will choose 1 or 2. The order will use the array values since
        // SyrupPowder types are {None, Sugar, Milk}
        int[] milkRandomValues = {0, 2};
        int randomBlended = 0;

        // Choose one of the TeaTypes
        var randomTea = randomGen.Next(1, 4);
        orderTea = (TeaTypes)randomTea;
        // Choose one of the ToppingTypes
        var randomTopping = randomGen.Next(0, 3);
        orderToppings = (ToppingsType)randomTopping;
        // Choose to add sugar
        var randomSyrupPowder = randomGen.Next(0, 2);
        orderSugar = (SyrupPowderType)randomSyrupPowder;
        // Choose to add ice
        var randomMilk = randomGen.Next(0, 2);
        orderMilk = (SyrupPowderType)milkRandomValues[randomMilk];
        // Choose to add ice
        var randomIce = randomGen.Next(0, 2);
        orderIce = randomIce != 0;
        // Choose to be shaken. If not shaken, then blend if there's ice
        var randomShake = randomGen.Next(0, 2);
        // True = 1, False = 0
        var randomShakeBool = randomShake != 0;
        orderShaked = randomShakeBool;
        // If randomShake is 0 and we have ice, we can blend
        if ((!randomShakeBool) && (randomIce == 1))
        {
            randomBlended = 1;
        }
        else
        {
            randomBlended = 0;
        }

        orderBlended = randomBlended != 0;

        Debug.Log("orderTea: " + orderTea);

        order = 
            randomTea.ToString() +
            randomTopping.ToString() +
            randomSyrupPowder.ToString() +
            milkRandomValues[randomMilk].ToString() +
            randomIce.ToString() +
            randomShake.ToString() +
            randomBlended.ToString();

        // Debug.Log("Ice: " + randomIce.ToString());
        // Debug.Log("Blended: " + randomBlended.ToString());
        Debug.Log("Order: " + order);
    }

    void Awake()
    {
        createOrderEncoding();
        Debug.Log("Order Generation ON!");
        drinksFailed = 0;
        drinksMade = 0;
        score = 0;
    }
}
