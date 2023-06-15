using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendMinigame : MonoBehaviour
{
    [SerializeField] GameObject GamePanel;
    private PlayerController playerController;
    private DrinkController drinkController;
    public AudioSource clip;
    public AudioSource success;
    public float delay = 1;
    float timer;

    public void PressButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }

    void OnEnable()
    {
        playerController.StopPlayer();
        if (drinkController._isBlendedUp)
        {
            PressButtonPanelClose();
        }
    }

    void OnDisable()
    {
        playerController.RestartPlayer();
    }

    void Awake()
    {
        this.drinkController = GameObject.FindGameObjectWithTag("Script Home").GetComponent<DrinkController>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void BlendDrink()
    {
        // Play animation here to blend
        clip.Play();
        StartCoroutine(WaitButtonPressed());
        drinkController.BlendUp();
    }

    IEnumerator WaitButtonPressed()
    {
        yield return new WaitForSeconds(8);
        Debug.Log("Drink is blended!");
        // Play sound here to signify completion
        // drinkController.CheckDrink();
        success.Play();
        if (timer > delay)
        {
            timer += Time.deltaTime;
            
            PressButtonPanelClose();
        }
        //PressButtonPanelClose();
    }
}
