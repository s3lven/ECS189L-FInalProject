using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeMinigame : MonoBehaviour
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
        if (drinkController._isShakenUp)
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

    public void ShakeDrink()
    {
        // Debug.Log("Minigame Start!");
        // Play animation here
        clip.Play();
        StartCoroutine(WaitButtonPressed());
        drinkController.ShakeUp();
    }

    IEnumerator WaitButtonPressed()
    {
        yield return new WaitForSeconds(5);
        // Play sound here to signify completion
        Debug.Log("Drink is shaked!!");
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
