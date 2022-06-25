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

    public int paddleCount = 4;

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;

    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;

    public GameObject GameOverCanvas;
    public GameObject ScoreCanvas;

    public List<int> LoseChecker;

    public BallControl ball;

    public PaddleControl pd;

    public void addP1Score(int increment)
    {
        
        p1score += increment;
        
        scoreChecker(p1score, P1, Wall1, 0);
    }

    public void addP2Score(int increment)
    {
        
        p2score += increment;
        
        scoreChecker(p2score, P2, Wall2, 1);
    }
    public void addP3Score(int increment)
    {
        
        p3score += increment;
        
        scoreChecker(p3score, P3, Wall3, 2);
    }
    public void addP4Score(int increment)
    {
        
        p4score += increment;
        
        scoreChecker(p4score, P4, Wall4, 3);
    }

    public void scoreChecker(int Score, GameObject paddle,GameObject Wall, int index)
    {
        if(Score >= maxScore)
        {
                LoseChecker[index] += 1;
                Destroy(paddle);
                Wall.SetActive(true);
                paddleCount -= 1;
                Debug.Log(paddleCount);
                if(paddleCount == 1)
                {
                    if(LoseChecker[0] == 0)
                    {
                        winner = "Player1";
                    }
                    else if(LoseChecker[1] == 0)
                    {
                        winner = "Player2";
                    }
                    else if(LoseChecker[2] == 0)
                    {
                        winner = "Player3";
                    }
                    else if(LoseChecker[3] == 0)
                    {
                        winner = "Player4";
                    }
                    gameOver();
                }
        }
       
        
    }
    public void gameOver()
    {
        ScoreCanvas.SetActive(false);
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
