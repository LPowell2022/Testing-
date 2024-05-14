using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    [Header("Monster")]
    public GameObject monster;

    [Header("Boss")]
    public GameObject boss;

    [Header("Ball 2")]
    public GameObject ball2;

    [Header("Ball 3")]
    public GameObject ball3;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    public void Player1Lose()
    {
        Player1Score--;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        ball2.GetComponent<Ball>().Reset();
        ball3.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }

    void Update ()
        {
               if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPosition();
        }
               if (Input.GetKeyDown(KeyCode.Escape))
                 {
                    SceneManager.LoadScene(2);
                 }
          }


}
