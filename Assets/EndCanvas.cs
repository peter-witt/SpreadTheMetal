﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCanvas : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("InGame");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
