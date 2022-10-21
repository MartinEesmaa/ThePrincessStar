using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void goback()
    {
        SceneManager.LoadScene("Start_Screen");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void howtoplay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void LobbyGameEntry()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}
