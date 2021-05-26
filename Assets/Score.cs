using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    float score = 0;
    public void Scorer(float value)
    {
        score = score + 1;
        scoreText.text = score.ToString();
    }
}
