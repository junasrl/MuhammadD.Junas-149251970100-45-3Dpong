using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Muhammad Destamal Junas - 149251970100-45");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
        Debug.Log("Created by Muhammad Destamal Junas - 149251970100-45");
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
