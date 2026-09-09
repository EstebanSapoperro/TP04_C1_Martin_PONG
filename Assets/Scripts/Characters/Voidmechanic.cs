using UnityEngine;

public class Voidmechanic : MonoBehaviour
{

    [SerializeField] private float basecooldown = 7.0f;


    [SerializeField] private SpriteRenderer voided;
    [SerializeField] private SpriteRenderer playerOne;
    [SerializeField] private SpriteRenderer playerTwo;
    [SerializeField] private GameObject gameOverPanel;
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
        cooldowntimer = basecooldown;
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
            Debug.Log("llego al timer2");
            if (playerOne.color != Color.black) 
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
            }

            voided.color = Color.black;
            danger = true;
        }

        if (cooldowntimer <= 0)
        {
            voided.color = Color.blue;
            cooldowntimer = basecooldown;
            danger = false;
            priWarning = false;
            secWarning = false;
            treWarning = false;
        }

    }

}
