using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    private GameObject player;
    public void ExitGame()
    {
        Application.Quit(); // Exit the game
    }
    public void Respawn()
    {
        player = GameObject.Find("PolicemanController(Clone)");
        if (player != null)
        {
            player.GetComponent<PlayerHealth>().RespawnPlayer();
        }

    }
}
