using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

}
