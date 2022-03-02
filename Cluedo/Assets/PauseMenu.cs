using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameStatus = false;

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameStatus)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameStatus = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameStatus = true;
    }

    public void LoadOptions()
    {
        Debug.Log("Loading menu...");
        //SceneManager.LoadScene("")
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
