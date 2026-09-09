using TMPro;
using UnityEngine;

public class DidMechanic : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI counter;
    [SerializeField] private Sprite[] faces;
     private Sprite actualSprite;
    [SerializeField] private float minbasecooldown = 5.0f;
    [SerializeField] private float maxbasecooldown = 8.0f;

    private int actualDirection = 0;
    //0 = none
    //1 = up
    //2 = right
    //3 = down
    //4 = left

    private float cooldowntimer;

    void Start()
    {
        actualDirection = Random.Range(1, 4);

        cooldowntimer = Random.Range(minbasecooldown, maxbasecooldown);

        if (actualDirection == 1) 
        {
            actualSprite = faces[1];
        }

        if (actualDirection == 2)
        {
            actualSprite = faces[2];
        }

        if (actualDirection == 3)
        {
            actualSprite = faces[3];
        }

        if (actualDirection == 4)
        {
            actualSprite = faces[4];
        }
    }

    private void FixedUpdate()
    {
        if (cooldowntimer >= -1.5)
        {
            cooldowntimer -= Time.deltaTime;
            counter.text = cooldowntimer.ToString("F1");
        }

        if (cooldowntimer <= 0) 
        {
            actualSprite = faces[0];

            if ((actualDirection == 1) && (GameManager.Stats.movingUp == false)) 
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
            }

            if ((actualDirection == 2) && (GameManager.Stats.movingRight == false))
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
            }

            if ((actualDirection == 3) && (GameManager.Stats.movingDown == false))
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
            }

            if ((actualDirection == 4) && (GameManager.Stats.movingLeft == false))
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
            }
        }

        if (cooldowntimer <= -1) 
        {
            actualDirection = Random.Range(1, 4);

            cooldowntimer = Random.Range(minbasecooldown, maxbasecooldown);

            if (actualDirection == 1)
            {
                actualSprite = faces[1];
            }

            if (actualDirection == 2)
            {
                actualSprite = faces[2];
            }

            if (actualDirection == 3)
            {
                actualSprite = faces[3];
            }

            if (actualDirection == 4)
            {
                actualSprite = faces[4];
            }

        }

    }
}
