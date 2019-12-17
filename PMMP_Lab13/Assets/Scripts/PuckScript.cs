using System.Collections;
using UnityEngine;

public class PuckScript : MonoBehaviour
{
    public ScoreScript ScoreScriptInstance;
    public static bool WasGoal { get; private set; }
    private Rigidbody2D rb;
    public AudioManager audioManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        WasGoal = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!WasGoal)
        {
            if (other.tag == "LeftPlayerGoal")
            {
                ScoreScriptInstance.Increment(ScoreScript.Score.RightPlayerScore);
                WasGoal = true;
                audioManager.PlayGoal();
                StartCoroutine(ResetPuck());
            }
            else if (other.tag == "RightPlayerGoal")
            {
                ScoreScriptInstance.Increment(ScoreScript.Score.LeftPlayerScore);
                WasGoal = true;
                audioManager.PlayGoal();
                StartCoroutine(ResetPuck());
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioManager.PlayPuckCollision();
    }

    public IEnumerator ResetPuck()
    {
        
        yield return new WaitForSecondsRealtime(0.3f);
        WasGoal = false;
        rb.velocity = rb.position = new Vector2(0, 0);
    }
}