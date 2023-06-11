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
        }
        else
        {
            Debug.Log("Failed!");
            drinkController.TrashDrink();
        }
    }

    void createOrderEncoding()
    {
        var randomGen = new System.Random();
        int[] milkRandomValues = {0, 2};

        var randomTea = randomGen.Next(0, 4);
        var randomTopping = randomGen.Next(0, 4);
        var randomSyrupPowder = randomGen.Next(0, 2);
        var randomMilk = randomGen.Next(0, 2);
        var randomIce = randomGen.Next(0, 2);
        var randomShake = randomGen.Next(0, 2);
        var randomShakeBool = randomShake != 0;
        var randomBlended = randomShakeBool ? 0 : 1;

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
        Debug.Log("I'm awake");
    }
}
