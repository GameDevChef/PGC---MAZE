using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Maze MazePrefab;

    private Maze m_mazeInstance;

    private void Start()
    {
        BeginGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            RestartGame();
    }

    private void RestartGame()
    {
        StopAllCoroutines();
        Destroy(m_mazeInstance.gameObject);
        BeginGame();
    }

    private void BeginGame()
    {
        m_mazeInstance = Instantiate(MazePrefab) as Maze;
        StartCoroutine(m_mazeInstance.Generate());
    }
}
