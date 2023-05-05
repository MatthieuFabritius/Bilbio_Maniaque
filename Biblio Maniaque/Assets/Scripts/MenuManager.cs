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

    public Transform newPosition;
    public Transform initialPosition;

    public void OpenOptionsPanel()
    {
        audioSource.PlayOneShot(buttonClick);
        optionsPanel.transform.position = newPosition.position;
    }

    public void OpenInstructionsPanel()
    {
        audioSource.PlayOneShot(buttonClick);
        instructionsPanel.transform.position = newPosition.position;
    }

    public void OpenCreditsPanel()
    {
        audioSource.PlayOneShot(buttonClick);
        creditsPanel.transform.position = newPosition.position; 
    }

    public void CloseOptionsPanel()
    {
        audioSource.PlayOneShot(buttonClick); 
        optionsPanel.transform.position = initialPosition.position;
    }

    public void CloseIntructionsPanel()
    {
        audioSource.PlayOneShot(buttonClick); 
        instructionsPanel.transform.position = initialPosition.position;
    }

    public void CloseCreditsPanel()
    {
        audioSource.PlayOneShot(buttonClick); 
        creditsPanel.transform.position = initialPosition.position;
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
