using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadScene("Level", LoadSceneMode.Single);
    }
public void Quit()
    {
        Application.Quit();
    }
public void Menu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
public void controls()
    {
        SceneManager.LoadScene("Controls", LoadSceneMode.Single);
    }
}
