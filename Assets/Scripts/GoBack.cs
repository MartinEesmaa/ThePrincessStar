using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Start_Screen");
    }
}
