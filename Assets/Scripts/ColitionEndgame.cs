using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ColitionEndgame : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] WinPanel winPanel;
    [SerializeField] private bool isPlayerOne = true;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ball"))
        {
            if (isPlayerOne == true)
            {
                GameManagerPONG.Stats.p2Win = true;
                GameManagerPONG.Stats.p2Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("Barrier", " Uno");
            }
            else 
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("Barrier", " Dos");
            }
            
        }
    }
}
