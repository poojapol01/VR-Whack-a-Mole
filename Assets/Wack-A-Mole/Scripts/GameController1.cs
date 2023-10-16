using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController1 : MonoBehaviour
{
    public Text timerText;
    public float gameTimer = 30f;

    private void Update()
    {
        gameTimer -= Time.deltaTime;

        if(gameTimer > 0f)
        {
            timerText.text = "WHACK A MOLE: " + Mathf.Floor(gameTimer);
        }
        else
        {
            timerText.text = "GAME OVER";
        }
    }
}
