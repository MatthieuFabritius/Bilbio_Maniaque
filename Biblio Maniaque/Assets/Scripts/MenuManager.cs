using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonClick;

    public GameObject optionsPanel;
    public GameObject instructionsPanel;
    public GameObject creditsPanel;

    public void OpenOptionsPanel()
    {
        optionsPanel.SetActive(true);
        CloseAllPanels();
    }

    public void OpenInstructionsPanel()
    {
        instructionsPanel.SetActive(true);
        CloseAllPanels();
    }

    public void OpenCreditsPanel()
    {
        creditsPanel.SetActive(true);
        CloseAllPanels();
    }

    public void CloseAllPanels()
    {
        optionsPanel.SetActive(false);
        instructionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
