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
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}