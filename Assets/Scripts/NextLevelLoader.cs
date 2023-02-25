using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoader : MonoBehaviour
{
    public int enemiesNumber;
    public GameObject victoryScreen;

    public void enemyKilled()
    {
        enemiesNumber--;
        if (enemiesNumber <= 0)
        {
            victoryScreen.SetActive(true);
            StartCoroutine(WaitToDisplay());
        }
    }

    IEnumerator WaitToDisplay()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
