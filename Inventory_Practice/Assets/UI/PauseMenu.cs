using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public void Return()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void ReturnToMenu()
    {
        SceneLoader.instance.LoadNewScene(GameScene.MainMenu);
    }

    public void Quit()
    {
        SceneLoader.instance.QuitGame();
    }
}
