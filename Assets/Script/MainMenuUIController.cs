using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    void Start()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void CreditScene()
    {
        SceneManager.LoadScene("Credit_Scene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
