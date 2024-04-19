using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGoal : MonoBehaviour
{

    public bool isPlayer1Lose;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Lose)
            {
                Debug.Log("Player 1 Lose...");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Lose();
            }
            else
            {
               
            }
        }
    }

}
