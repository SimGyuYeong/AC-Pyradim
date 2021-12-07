using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject StartMenu;
    private Fungus.Stop stop;
    [SerializeField]
    private Fungus.SaveMenu save;
    private bool isStart = false;

    private void Start()
    {
        stop = FindObjectOfType<Fungus.Stop>();
    }

    public void Update()
    {
        if (isStart)
        {
            if (Input.GetKeyDown(KeyCode.Escape)) Pause();
        }
    }

    private void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void Continue()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameStart()
    {
        isStart = true;
        StartMenu.SetActive(false);
    }

    public void GotoStart()
    {
        isStart = false;
        Continue();
        StartMenu.SetActive(true);
    }
}
