using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    private bool isPause = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPause) Pause();
            else if (isPause) NoPause();
        }
    }

    private void Pause()
    {
        isPause = true;
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    private void NoPause()
    {
        isPause = false;
        PauseMenu.SetActive(false);
        Time.timeScale = 0f;
    }

    private void Continue()
    {
        isPause = false;
        Time.timeScale = 1f;
    }
}
