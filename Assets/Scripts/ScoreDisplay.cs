using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreDisplay : MonoBehaviour
{
    public NextLevelLoader score;

    private int neededScore;
    private int currentScore;
    public Text text;
    public GameObject info;

    private void Awake()
    {
        neededScore = score.enemiesNumber;
    }

    void Start()
    {
        info.SetActive(false);
    }

    void Update()
    {
        if ((neededScore - score.enemiesNumber) >= 1)
        {
            info.SetActive(true);
            text.text = (neededScore - score.enemiesNumber) + " / " + neededScore;
        }
    }
}
