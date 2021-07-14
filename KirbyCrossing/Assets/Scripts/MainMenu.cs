using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LaunchFlood()
    {
        SceneManager.LoadScene("Flood");
    }
    public void LaunchFire()
    {
        SceneManager.LoadScene("Fire");
    }

    public void QuitApp()
    {
        Application.Quit();
    }

}
