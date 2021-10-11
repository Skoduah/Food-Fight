using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToScore : MonoBehaviour
{
    public Text score;
    public int scoreText;
    public int pointsEarned = 10;
    // Adds score accumulated into text
    public void AddScore()
    {
        scoreText += pointsEarned;
        score.text = "Score: " + scoreText.ToString();
    }
    // Deducts score accumulated into text
    public void LosePointa()
    {
        scoreText -= pointsEarned;
        score.text = "Score: " + scoreText.ToString();
    }
}
