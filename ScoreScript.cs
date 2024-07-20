using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Score", 0.7f, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    private void Score()
    {
        score = score + 1;
        print("Score : " + score);
    }
}
