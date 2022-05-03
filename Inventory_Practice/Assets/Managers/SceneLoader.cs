using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance { get; private set; }

    private GameScene _currentScene;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadNewScene(GameScene newScene)
    {
        if (newScene == _currentScene) return;
        SceneManager.LoadScene((int)newScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

public enum GameScene
{
    MainMenu,
    Test,
    Quit
}
