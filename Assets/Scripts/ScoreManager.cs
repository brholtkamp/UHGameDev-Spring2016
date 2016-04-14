using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    private Text Score;

    private int CurrentScore = 0;

    private void Awake() {
        Score = GetComponent<Text>();
        Score.text = "Score: 0";
    }

    public void IncrementScore() {
        CurrentScore += 1;
        Score.text = string.Format("Score: {0}", CurrentScore);
    }
}
