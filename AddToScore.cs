using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToScore : MonoBehaviour
{
    public Text score;
    public int scoreText;
    public int pointsEarned = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        scoreText += pointsEarned;
        score.text = "Score: " + scoreText.ToString();
    }
    public void LosePointa()
    {
        scoreText -= pointsEarned;
        score.text = "Score: " + scoreText.ToString();
    }
}
