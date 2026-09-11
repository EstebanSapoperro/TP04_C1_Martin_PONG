using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class NotMechanic : MonoBehaviour
{
    [SerializeField] WinPanel winPanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI counter;
    [SerializeField] private Sprite[] faces;
    private Sprite actualSprite;

    [SerializeField] private Image visualSprite;
    [SerializeField] private float minbasecooldown = 3.0f;
    [SerializeField] private float maxbasecooldown = 11.0f;
    [SerializeField] private float timeDetection = -0.5f;

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
            visualSprite.sprite = actualSprite;
        }

        if (actualDirection == 2)
        {
            actualSprite = faces[2];
            visualSprite.sprite = actualSprite;
        }

        if (actualDirection == 3)
        {
            actualSprite = faces[3];
            visualSprite.sprite = actualSprite;
        }

        if (actualDirection == 4)
        {
            actualSprite = faces[4];
            visualSprite.sprite = actualSprite;
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
            visualSprite.sprite = actualSprite;

            if ((actualDirection == 1) && (GameManagerPONG.Stats.p1movingUp == true))
            {
                GameManagerPONG.Stats.p2Win = true;
                GameManagerPONG.Stats.p2Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get see by Did", " One");
            }
            else if ((actualDirection == 1) && (GameManagerPONG.Stats.p2movingUp == true))
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get see by Did", " Two");
            }

            if ((actualDirection == 2) && (GameManagerPONG.Stats.p1movingRight == true))
            {
                GameManagerPONG.Stats.p2Win = true;
                GameManagerPONG.Stats.p2Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get see by Did", " One");
            }
            else if ((actualDirection == 2) && (GameManagerPONG.Stats.p2movingRight == true))
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get see by Did", " Two");
            }

            if ((actualDirection == 3) && (GameManagerPONG.Stats.p1movingDown == true))
            {
                GameManagerPONG.Stats.p2Win = true;
                GameManagerPONG.Stats.p2Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get see by Did", " One");
            }
            else if ((actualDirection == 3) && (GameManagerPONG.Stats.p2movingDown == true))
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get see by Did", " Two");
            }

            if ((actualDirection == 4) && (GameManagerPONG.Stats.p1movingLeft == true))
            {
                GameManagerPONG.Stats.p2Win = true;
                GameManagerPONG.Stats.p2Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get see by Did", " One");
            }
            else if ((actualDirection == 4) && (GameManagerPONG.Stats.p2movingLeft == true))
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get see by Did", " Two");
            }
        }

        if (cooldowntimer <= timeDetection)
        {
            actualDirection = Random.Range(1, 4);

            cooldowntimer = Random.Range(minbasecooldown, maxbasecooldown);

            if (actualDirection == 1)
            {
                actualSprite = faces[1];
                visualSprite.sprite = actualSprite;
            }

            if (actualDirection == 2)
            {
                actualSprite = faces[2];
                visualSprite.sprite = actualSprite;
            }

            if (actualDirection == 3)
            {
                actualSprite = faces[3];
                visualSprite.sprite = actualSprite;
            }

            if (actualDirection == 4)
            {
                actualSprite = faces[4];
                visualSprite.sprite = actualSprite;
            }

        }

    }
}
