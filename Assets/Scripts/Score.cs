using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int currentScore;
    public Text bestScoreText;
    private int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }
    private void HandleScore()
    {
        bestScoreText.text = "Best Score:" + bestScore;
        scoreText.text = "Score: " + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
