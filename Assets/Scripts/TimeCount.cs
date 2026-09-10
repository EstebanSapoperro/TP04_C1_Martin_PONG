using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
public class TimeCount : MonoBehaviour
{
    [SerializeField] WinPanel winPanel;
    [SerializeField] private GameObject gameOverPanel;
    private float baseTime = 20.0f;
    private bool finished = false;
    [SerializeField] private GameObject ball;
    [SerializeField] private TextMeshProUGUI counter;
    private float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = baseTime;
    }
    private void Update()
    {
        time -= Time.deltaTime;
        counter.text = time.ToString("F1");

        if ((time < 0)&&(finished == false)) 
        {
            finished = true;
            if (ball.transform.localPosition.x < -0.2)
            {
                GameManagerPONG.Stats.p2Win = true;
                GameManagerPONG.Stats.p2Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("desempate, la bola esstaba de su lado de la cancha", " One");
            }
            else 
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("desempate, la bola esstaba de su lado de la cancha", " Two");
            }
        
        }
    }

}
