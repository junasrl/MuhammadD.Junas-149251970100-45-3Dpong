using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int p1score;
    public int p2score;
    public int p3score;
    public int p4score;
    public int maxScore;

    public string winner;

    private int paddleCount = 4;

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;

    private bool p1 = false;
    private bool p2 = false;
    private bool p3 = false;
    private bool p4 = false;

    public BallControl ball;

    public void addP1Score(int increment)
    {
        
        p1score += increment;
        
        scoreChecker(p1score, P1, p1);
    }

    public void addP2Score(int increment)
    {
        
        p2score += increment;
        
        scoreChecker(p2score, P2, p2);
    }
    public void addP3Score(int increment)
    {
        
        p3score += increment;
        
        scoreChecker(p3score, P3, p3);
    }
    public void addP4Score(int increment)
    {
        
        p4score += increment;
        
        scoreChecker(p4score, P4, p4);
    }

    public void scoreChecker(int Score, GameObject paddle,bool loseCheck)
    {
        if(Score >= maxScore)
        {
            paddleCount -= 1;
            if(paddleCount == 1)
            {
                gameOver();
                if(p1 == false)
                {
                    winner = "Player1";
                }
                else if(p2 == false)
                {
                    winner = "Player2";
                }
                else if(p3 == false)
                {
                    winner = "Player3";
                }
                else if(p4 == false)
                {
                    winner = "Player4";
                }
            }
            else
            {
                Destroy(paddle);
                loseCheck = true;
            }
    }
    }
    public void gameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
