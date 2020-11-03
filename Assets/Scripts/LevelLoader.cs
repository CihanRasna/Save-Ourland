using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private int _currentSceneIndex;
    [SerializeField] private float waitTime = 3f;

    private void Start()
    {
        _currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (_currentSceneIndex == 0)
        {
            StartCoroutine(LoadStartScene());
        }
    }
    
    IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(_currentSceneIndex + 1);
    }

    public void LoadGameScreen()
    {
        
    }

    public void QuitGame()
    {
        
    }

    public void RestartGameScreen()
    {
        
    }

}