using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    [SerializeField] GameObject cupObject;
    private PlayerController playerController;
    private DrinkController drinkController;
    public int iceCount;

    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }

    void OnEnable()
    {
        playerController.StopPlayer();
        iceCount = 0;

    }

    void OnDisable()
    {
        playerController.RestartPlayer();
    }

    void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        this.drinkController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<DrinkController>();
    }

    void Update()
    {
        // Completes when the player has put two ice units in the cup
        if (iceCount == 2)
        {
            // Debug.Log("Ice count: " + iceCount);
            CheckIce();
        }
    }

    void CheckIce()
    {
        Debug.Log("Sent Ice");
        drinkController.AddIce();
        // Debug function
        // drinkController.CheckDrink();
        // Play sound here to signify completion
        // Debug function
        // drinkController.CheckDrink();
        PressButtonPanelClose();
    }


}
