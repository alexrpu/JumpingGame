using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Rigidbody2D player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(scoreText.text) < player.position.y)
        {
			scoreText.text = player.position.y.ToString("0");
		}
	}
}
