using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public event Action<GameState> GameStateChanged;

    private GameState _currentGameState;

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

    private void Start()
    {
        UpdateGameState(GameState.StartGame);
    }

    public void UpdateGameState(GameState newGameState)
    {
        if (_currentGameState == newGameState) return;
        _currentGameState = newGameState;

        switch (_currentGameState)
        {
            case GameState.StartGame:
                break;
        }
        GameStateChanged?.Invoke(_currentGameState);
    }
}

public enum GameState
{
    StartGame,
}
