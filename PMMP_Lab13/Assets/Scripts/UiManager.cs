using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [Header("Canvas")]
    public GameObject CanvasGame;
    public GameObject CanvasRestart;

    [Header("CanvasRestart")]
    public GameObject RedWin;
    public GameObject BlueWin;

    [Header("Other")]
    public AudioManager audioManager;

    public ScoreScript scoreScript;

    public PuckScript puckScript;
    public LeftPlayer leftPlayer;
    public RightPlayer rightPlayer;

    public void ShowRestartCanvas(bool rightPlayerWin)
    {
        Time.timeScale = 0;

        CanvasGame.SetActive(false);
        CanvasRestart.SetActive(true);

        if (rightPlayerWin)
        {
            RedWin.SetActive(false);
            BlueWin.SetActive(true);
        }
        else
        {
            RedWin.SetActive(true);
            BlueWin.SetActive(false);
        }
        audioManager.PlayEndGame();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;

        CanvasGame.SetActive(true);
        CanvasRestart.SetActive(false);

        leftPlayer.ResetPosition();
        rightPlayer.ResetPosition();
        scoreScript.ResetScores();
        puckScript.ResetPuck();
    }
}
