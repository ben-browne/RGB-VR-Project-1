using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour
{

    public void StartPressed()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void StoryPressed()
    {
        SceneManager.LoadScene("StoryScreen");

    }
    public void BackPressed()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
