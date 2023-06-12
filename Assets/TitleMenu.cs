using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public GameObject controlsPanel;

    public void StartGame()
    {
        ScoreController.Reset();
        SceneManager.LoadScene("MainScene");
    }

    public void OpenPanel()
    {
        if (controlsPanel!=null)
        {
            Debug.Log("Panel opened");
            controlsPanel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (controlsPanel!=null)
        {
            Debug.Log("Panel closed");
            controlsPanel.SetActive(false);
        }
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Exited Game");
    }
}
