using UnityEngine;
using UnityEngine.UIElements;

public class Voidmechanic : MonoBehaviour
{

    [SerializeField] private float minbasecooldown;
    [SerializeField] private float maxbasecooldown;

    [SerializeField] VoidDataSo data;
    [SerializeField] private SpriteRenderer voided;
    [SerializeField] private SpriteRenderer playerOne;
    [SerializeField] private SpriteRenderer playerTwo;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject voidPanel;
    [SerializeField] WinPanel winPanel;
    private float cooldowntimer;
    private bool priWarning = false;
    private bool secWarning = false;
    private bool treWarning = false;
    private bool danger = false;

    private float countPriWarning;
    private float countSecWarning;
    private float countTreWarning;
    private float countDanger = 0.5f;

    void Start()
    {
        countPriWarning = data.countPriWarning;
        countSecWarning = data.countSecWarning;
        countTreWarning = data.countTreWarning;

        minbasecooldown = data.minbasecooldown;
        maxbasecooldown = data.maxbasecooldown;
        cooldowntimer = Random.Range(minbasecooldown, maxbasecooldown);
    }
    private void FixedUpdate()
    {
        if (cooldowntimer >= -1) 
        {
         cooldowntimer -= Time.deltaTime;
        }

        if ((cooldowntimer <= countPriWarning)&&(priWarning == false)) 
        {
            voided.color = data.priWarningColor;
            priWarning = true;
        }

        if ((cooldowntimer <= countSecWarning) && (secWarning == false))
        {
            voided.color = data.secWarningColor;
            secWarning = true;
        }

        if ((cooldowntimer <= countTreWarning) && (treWarning == false))
        {
            voided.color = data.treWarningColor;
            treWarning = true;
        }

        if ((cooldowntimer <= countDanger) && (danger == false))
        {
            if (playerOne.color != Color.black) 
            {
                GameManagerPONG.Stats.p2Win = true;
                GameManagerPONG.Stats.p2Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("que lo vio Void", " Uno");
            }
            else if (playerTwo.color != Color.black)
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("que lo vio Void", " Dos");
            }
            voidPanel.SetActive(true);
            voided.color = Color.black;
            danger = true;
        }

        if (cooldowntimer <= 0)
        {
            voided.color = data.baseColor;
            cooldowntimer = Random.Range(minbasecooldown, maxbasecooldown);
            voidPanel.SetActive(false);
            danger = false;
            priWarning = false;
            secWarning = false;
            treWarning = false;
        }

    }

}
