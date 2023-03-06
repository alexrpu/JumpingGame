using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Rigidbody2D player;
    public Text scoreText;
    public Text highscoreText;
    public static int lastscore;
    public static int highscore = 0;

    // Update is called once per frame
    void Start()
    {
        highscoreText.text = "Highscore: "+highscore.ToString("0");
    }

    void Update()
    {
        if (int.Parse(scoreText.text) < player.position.y)
        {
            scoreText.text = player.position.y.ToString("0");
            lastscore = (int) player.position.y;
            
        }

        if (int.Parse(scoreText.text) - player.position.y > 6)
        {
            if (highscore < lastscore) 
            {
                highscore = lastscore;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2) ;
        }
    }
}
