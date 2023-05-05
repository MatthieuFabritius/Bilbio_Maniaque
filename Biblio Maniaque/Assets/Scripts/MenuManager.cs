using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonClick;

    public GameObject optionsPanel;
    public GameObject instructionsPanel;
    public GameObject creditsPanel;

    public void OpenOptionsPanel()
    {
        Vector3 pos = optionsPanel.transform.position;
        pos.x = 300f;
        optionsPanel.transform.position = pos;

        CloseAllPanels();
    }

    public void OpenInstructionsPanel()
    {
        Vector3 pos = instructionsPanel.transform.position;
        pos.x = 300f;
        instructionsPanel.transform.position = pos;
        CloseAllPanels();
    }

    public void OpenCreditsPanel()
    {
        Vector3 pos = creditsPanel.transform.position;
        pos.x = 300f;
        creditsPanel.transform.position = pos;
        CloseAllPanels();
    }

    public void CloseAllPanels()
    {
        Vector3 pos = optionsPanel.transform.position;
        pos.x = -300f;
        optionsPanel.transform.position = pos;

        pos = instructionsPanel.transform.position;
        pos.x = -300f;
        instructionsPanel.transform.position = pos;

        pos = creditsPanel.transform.position;
        pos.x = -300f;
        creditsPanel.transform.position = pos;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
}
