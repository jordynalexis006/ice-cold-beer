﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void RestartLevel()
    {
        GameOver.IsGameOver = false;
        SceneManager.LoadScene("GameScene");
    }

    public void ReturnToMainMenu()
    {
        GameOver.IsGameOver = false;
        SceneManager.LoadScene("Title Screen");

    }
}
