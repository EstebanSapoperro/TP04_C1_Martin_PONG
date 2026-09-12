using System;
using UnityEngine;
using UnityEngine.UIElements;

public class PONGMechanic : MonoBehaviour
{
    [SerializeField] WinPanel winPanel;
    [SerializeField] private GameObject gameOverPanel;
    private void OnCollisionEnter2D(Collision2D other)
    {


        PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();

        if (player != null) 
        {
            if (player.isPlayerOne) 
            {
                GameManagerPONG.Stats.p2Win = true;
                GameManagerPONG.Stats.p2Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("que lo corto PONG", " Uno");
            }
            else
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("que lo corto PONG", " Dos");
            }


        }
    }
}
