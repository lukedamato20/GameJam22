using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Help()
    {
        SceneManager.LoadScene("Help");
    }
    public void Hub()
    {
        SceneManager.LoadScene("Hub");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}