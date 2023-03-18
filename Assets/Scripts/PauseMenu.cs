using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] GameObject menu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            isPaused = !isPaused;
            if (isPaused)
            {
                Pause();
            }

            else
            {
                Unpause();
            }
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        isPaused = false;
    }

    public void Exit()
    {
        Debug.Log("ISJUNGTA");
        Application.Quit();
    }
}
