using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float lives;
    public TextMeshProUGUI livesText;

    public float score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
