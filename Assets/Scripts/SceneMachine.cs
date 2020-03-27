using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMachine : MonoBehaviour
{
    // This script handles all scene management for the game

    public void ReloadScene() // Reloads current scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextScene() // Load next scene on the build index
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenuScene() // Load the menu scene
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName("MainMenu").buildIndex + 1);
    }

    public void ExitGame() // Exit the game
    {
        Application.Quit();
    }
}
