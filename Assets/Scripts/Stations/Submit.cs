using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submit : MonoBehaviour
{
    // Yellow highlight that surrounds the interactable when the player is near
    GameObject highlight;
    OrderController orderController;
    public AudioSource clip;

    // Grabs the highlight object
    private void OnEnable()
    {
        highlight = transform.GetChild(0).gameObject;
    }

    // When the player's colllider hits the box's, light up
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            highlight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            highlight.SetActive(false);
        }
    }

    void Awake()
    {
        orderController = GameObject.FindObjectOfType<OrderController>();
    }

    // Called when the user left clicks the interactable. Turns on the minigame panel.
    public void PlayMiniGame()
    {
        // Grab the recipe
        // Grab the drink from the DrinkController
        // Compare to see if they have all the ingredients
        orderController.checkEncoding();
    }
}
