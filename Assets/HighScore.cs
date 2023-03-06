using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update

    void Start()
    {
        scoreText.text = "Highscore: "+Score.highscore.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
