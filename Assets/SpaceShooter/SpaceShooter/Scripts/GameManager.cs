
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

 

public class GameManager : Singleton<GameManager>
{
    enum State
    {
        TITLE,
        GAME
    }

    [SerializeField] GameObject playerPrefab;
    [SerializeField] Transform playerSpawn;
    [SerializeField] GameObject titleScreen;
    [SerializeField] TMP_Text scoreUI;

    public delegate void GameEvent();

    public event GameEvent startGameEvent;
    public event GameEvent stopGameEvent;

    int score = 0;
    State state = State.TITLE;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            scoreUI.text = score.ToString();
        }
    }
    public int Lives { get; set; }

    public void OnStartGame()
    {
        state = State.GAME;
        titleScreen.SetActive(false);
        Instantiate(playerPrefab, playerSpawn.position, playerSpawn.rotation);
        startGameEvent?.Invoke();
        //stopGameEvent?.Invoke();
    }

    public void OnStopGame()
    { 
    
    }

    public void OnStartTitle()
    {
        state = State.TITLE;
        titleScreen.SetActive(true);
        stopGameEvent();
    }
}
