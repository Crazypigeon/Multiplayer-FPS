using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreDisplay : MonoBehaviour
{
    public NextLevelLoader score;

    private int neededScore;
    private int currentScore;
    private Text text;

    private void Awake()
    {
        text = this.GetComponent<Text>();
        neededScore = score.enemiesNumber;
    }

    void Start()
    {
        text.text = "įveikei " + (neededScore - score.enemiesNumber) + " priešus iš " + neededScore;
    }

    void Update()
    {
        text.text = "įveikei " + (neededScore - score.enemiesNumber) + " priešus iš " + neededScore;
    }
}
