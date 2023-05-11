using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] GameObject menu;
    private FirstPersonController fpController;
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
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
        fpController = GameObject.Find("PolicemanController(Clone)").GetComponent<FirstPersonController>();
        fpController.m_MouseLook.SetCursorLock(false);
        fpController.m_MouseLook.UpdateCursorLock();
        fpController.enabled = false;
        Time.timeScale = 0;
        Cursor.visible = false;
        menu.SetActive(true);
    }

    public void Unpause()
    {
        fpController = GameObject.Find("PolicemanController(Clone)").GetComponent<FirstPersonController>();
        fpController.enabled = true;
        fpController.m_MouseLook.SetCursorLock(true);
        fpController.m_MouseLook.UpdateCursorLock();
        Time.timeScale = 1;
        Cursor.visible = true;
        menu.SetActive(false);
        isPaused = false;
    }

    public void Exit()
    {
        Debug.Log("ISJUNGTA");
        Application.Quit();
    }
}
