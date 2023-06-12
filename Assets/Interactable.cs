using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Minigame that will start when interacted with
    [SerializeField] GameObject miniGame;
    // Yellow highlight that surrounds the interactable when the player is near
    GameObject highlight;

    // Grabs the highlight object
    private void OnEnable()
    {
        highlight = transform.GetChild(0).gameObject;
    }

    // When the player's colllider hits the box's, light up
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Collide: " + other.gameObject.name);
        if(other.tag == "Player")
        {
            highlight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            highlight.SetActive(false);
        }
    }

    // Called when the user left clicks the interactable. Turns on the minigame panel.
    public void PlayMiniGame()
    {
        miniGame.SetActive(true);
    }
}
