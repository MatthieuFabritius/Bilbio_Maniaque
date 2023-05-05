using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    public void OnClickScene01(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnClickScene02(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnClickScene03(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnClickMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
