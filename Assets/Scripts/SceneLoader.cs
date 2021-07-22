using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void RealoadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // this variable + load scene is usefull if we have multiple scenes, otherwise just use SceneManager.LoadScene(0);
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
