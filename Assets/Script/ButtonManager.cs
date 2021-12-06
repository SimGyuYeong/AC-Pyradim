using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject showEnding;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            CloseEnding();
        }
    }

    public void CloseEnding()
    {
        showEnding.SetActive(false);
    }

    public void ShowEnding()
    {
        showEnding.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
