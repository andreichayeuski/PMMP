using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public enum Score
    {
        LeftPlayerScore, RightPlayerScore
    }

    public Text LeftPlayerScoreTxt, RightPlayerScoreTxt;
    private int leftPlayerScore, rightPlayerScore;

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.LeftPlayerScore)
        {
            LeftPlayerScoreTxt.text = (++leftPlayerScore).ToString();
        }
        else
        {
            RightPlayerScoreTxt.text = (++rightPlayerScore).ToString();
        }
    }
}