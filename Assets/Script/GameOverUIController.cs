using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUIController : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
