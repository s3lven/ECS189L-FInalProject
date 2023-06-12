using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderController : MonoBehaviour
{
    [SerializeField] DrinkController drinkController;
    private string order;
    private string drink;
    public int points = 10;
    public int drinksFailed;
    public int drinksMade;

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
        }
        else
        {
            Debug.Log("Failed!");
            drinkController.TrashDrink();
            drinksFailed++;
        }
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
        // Choose one of the ToppingTypes
        var randomTopping = randomGen.Next(0, 3);
        // Choose to add sugar
        var randomSyrupPowder = randomGen.Next(0, 2);
        // Choose to add ice
        var randomMilk = randomGen.Next(0, 2);
        // Choose to add ice
        var randomIce = randomGen.Next(0, 2);
        // Choose to be shaken. If not shaken, then blend if there's ice
        var randomShake = randomGen.Next(0, 2);
        var randomShakeBool = randomShake != 0;
        if ((!randomShakeBool) && (randomIce != 0))
        {
            randomBlended = 1;
        }

        order = 
            randomTea.ToString() +
            randomTopping.ToString() +
            randomSyrupPowder.ToString() +
            milkRandomValues[randomMilk].ToString() +
            randomIce.ToString() +
            randomShake.ToString() +
            randomBlended.ToString();

        Debug.Log("Order: " + order);
    }

    void Awake()
    {
        createOrderEncoding();
        Debug.Log("Order Generation ON!");
        drinksFailed = 0;
        drinksMade = 0;
    }
}
