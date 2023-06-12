using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] PlayerController playerController;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (pausePanel.activeSelf)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void Pause()
    {
        if (pausePanel!=null)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
            // playerController.StopPlayer();
        }
    }

    public void Resume()
    {
        if (pausePanel!=null)
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
            // playerController.RestartPlayer();
        }
    }

    public void Restart(string sceneName)
    {
        Time.timeScale = 1f;
        ScoreController.Reset();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Home(string sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
}
