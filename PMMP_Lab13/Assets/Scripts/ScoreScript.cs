using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public enum Score
    {
        LeftPlayerScore, RightPlayerScore
    }

    public Text LeftPlayerScoreTxt, RightPlayerScoreTxt;
    public UiManager uiManager;

    public int MaxScore;

    #region Scores
    private int leftPlayerScore, rightPlayerScore;

    private int LeftPlayerScore
    {
        get { return leftPlayerScore; }
        set
        {
            leftPlayerScore = value;
            if (value == MaxScore)
                uiManager.ShowRestartCanvas(false);
        }
    }

    private int RightPlayerScore
    {
        get { return rightPlayerScore; }
        set
        {
            rightPlayerScore = value;
            if (value == MaxScore)
                uiManager.ShowRestartCanvas(true);
        }
    }
    #endregion

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.LeftPlayerScore)
        {
            LeftPlayerScoreTxt.text = (++LeftPlayerScore).ToString();
        }
        else
        {
            RightPlayerScoreTxt.text = (++RightPlayerScore).ToString();
        }
    }

    public void ResetScores()
    {
        leftPlayerScore = rightPlayerScore = 0;
        LeftPlayerScoreTxt.text = RightPlayerScoreTxt.text = "0";
    }
}