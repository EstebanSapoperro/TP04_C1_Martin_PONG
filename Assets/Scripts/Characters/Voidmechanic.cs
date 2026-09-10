using UnityEngine;
using UnityEngine.UIElements;

public class Voidmechanic : MonoBehaviour
{

    [SerializeField] private float minbasecooldown = 6.0f;
    [SerializeField] private float maxbasecooldown = 8.0f;

    [SerializeField] PlayerDataSo data;
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

    private float countPriWarning = 3;
    private float countSecWarning = 2;
    private float countTreWarning = 1;
    private float countDanger = 0.5f;

    void Start()
    {
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
            Debug.Log("llego al timer1");
            voided.color = Color.darkBlue;
            priWarning = true;
        }

        if ((cooldowntimer <= countSecWarning) && (secWarning == false))
        {
            Debug.Log("llego al timer3");
            voided.color = Color.darkRed;
            secWarning = true;
        }

        if ((cooldowntimer <= countTreWarning) && (treWarning == false))
        {
            Debug.Log("llego al Danegr");
            voided.color = Color.red;
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
                winPanel.DeadRason("get seen by Void", " One");
            }
            else if (playerTwo.color != Color.black)
            {
                GameManagerPONG.Stats.p1Win = true;
                GameManagerPONG.Stats.p1Wins++;
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                winPanel.DeadRason("get seen by Void", " Two");
            }
            voidPanel.SetActive(true);
            voided.color = Color.black;
            danger = true;
        }

        if (cooldowntimer <= 0)
        {
            voided.color = Color.blue;
            cooldowntimer = Random.Range(minbasecooldown, maxbasecooldown);
            voidPanel.SetActive(false);
            danger = false;
            priWarning = false;
            secWarning = false;
            treWarning = false;
        }

    }

}
