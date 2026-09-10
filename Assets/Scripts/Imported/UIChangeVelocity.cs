using TMPro;
using UnityEngine;
using UnityEngine.UI;
//esto fue un error de diseño, pense que seria mejora el tener 1 solo script encargado de los sliders
//puesto que me resultaba mas confuso tener 6 scripts para todas las modificaiones que podian hacer los sliders
//pero ahora me doy cuenta que si me servia tener separado esos 6 scripts, ya que me permitiria hacer una funcion mas compleja que queria hacer, pero bueno
public class UIChangeVelocity : MonoBehaviour
{

    [SerializeField] private bool isPlayer1 = true;
    [SerializeField] private bool isPlayer2 = false;
    [SerializeField] private bool color = false;
    [SerializeField] private bool velocity = true;
    [SerializeField] private bool scale = false;

    [SerializeField] private Slider slider;

    [SerializeField] private Movement valuevelocityOfPlayer;

    [SerializeField] private GameObject playerselected;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Image demostrationCube;
    [SerializeField] private TMP_Text textCounter;

    [SerializeField] private bool Redp1 = false;
    [SerializeField] private bool Redp2 = false;
    [SerializeField] private bool Bluep1 = false;
    [SerializeField] private bool Bluep2 = false;
    [SerializeField] private bool Greenp1 = false;
    [SerializeField] private bool Greenp2 = false;
    [SerializeField] private bool Player1 = true;
    [SerializeField] private bool Player2 = true;

    private void Awake()
    {
        slider.onValueChanged.AddListener(Changevalue);
    }





    void Start()
    {
        if (isPlayer1)
        {
            if (velocity)
            {
                slider.value = GameManager.Config.VelocityP1;


            }
            if (scale)
            {
                slider.value = GameManager.Config.YScaleP1;

            }
            if (color)
            {
                if (Redp1)
                {
                    slider.value = GameManager.Config.RP1;

                }
                if (Bluep1)
                {
                    slider.value = GameManager.Config.BP1;

                }
                if (Greenp1)
                {
                    slider.value = GameManager.Config.GP1;

                }
                if (demostrationCube != null) 
                {
                    demostrationCube.color = new Color(GameManager.Config.RP1, GameManager.Config.GP1, GameManager.Config.BP1);

                }

            }


        }

        if (isPlayer2)
        {
            if (velocity)
            {
                slider.value = GameManager.Config.VelocityP2;


            }
            if (scale)
            {
                slider.value = GameManager.Config.YScaleP2;

            }
            if (color)
            {
                if (Redp2)
                {
                    slider.value = GameManager.Config.RP2;

                }
                if (Bluep2)
                {
                    slider.value = GameManager.Config.BP2;

                }
                if (Greenp2)
                {
                    slider.value = GameManager.Config.GP2;

                }
                if (demostrationCube != null)
                {
                    demostrationCube.color = new Color(GameManager.Config.RP2, GameManager.Config.GP2, GameManager.Config.BP2);

                }

            }


        }


    }
    private void OnDestroy()
    {
        slider.onValueChanged.RemoveAllListeners();
    }
    private void Changevalue(float value)
    {
        if (velocity == true)
        {
            if (valuevelocityOfPlayer != null)
            {
                valuevelocityOfPlayer.velocity = value;
                



            }
            if (textCounter != null)
            {
                textCounter.text = value.ToString("F1");
            }
            if (isPlayer1)
            {

                GameManager.Config.VelocityP1 = value;

            }
            else if (isPlayer2)
            {

                GameManager.Config.VelocityP2 = value;

            }

        }

        if (color == true)
        {

            if (playerSprite != null)
            {

                Color p = playerSprite.color;
                if (Greenp1 == true || Greenp2 == true)
                {
                    p.g = value;

                    playerSprite.color = p;
                }
                if (Redp1 == true || Redp2 == true)
                {
                    p.r = value;

                    playerSprite.color = p;
                }
                if (Bluep1 == true || Bluep2 == true)
                {
                    p.b = value;

                    playerSprite.color = p;
                }

            }

            if (demostrationCube != null)
            {
                Color c = demostrationCube.color;
                if (Greenp1 == true || Greenp2 == true)
                {

                    c.g = value;
                    demostrationCube.color = c;

                }
                if (Redp1 == true || Redp2 == true)
                {

                    c.r = value;
                    demostrationCube.color = c;

                }
                if (Bluep1 == true || Bluep2 == true)
                {

                    c.b = value;
                    demostrationCube.color = c;

                }

            }



            if (isPlayer1)
            {
                if (Redp1 == true)
                {
                    GameManager.Config.RP1 = value;
                }
                if (Greenp1 == true)
                {
                    GameManager.Config.GP1 = value;
                }
                if (Bluep1 == true)
                {
                    GameManager.Config.BP1 = value;
                }


            }
            else if (isPlayer2)
            {

                if (Redp2 == true)
                {
                    GameManager.Config.RP2 = value;
                }
                if (Greenp2 == true)
                {
                    GameManager.Config.GP2 = value;
                }
                if (Bluep2 == true)
                {
                    GameManager.Config.BP2 = value;
                }

            }


        }
        if (scale == true)
        {
            if (playerselected != null)
            {
                playerselected.transform.localScale = new Vector3(1, value, 1);
                

            }
            if (textCounter != null)
            {
                textCounter.text = value.ToString("F1");
            }
            if (Player1 == true)
            {
                GameManager.Config.YScaleP1 = value;
            }
            if (Player2 == true)
            {
                GameManager.Config.YScaleP2 = value;
            }


        }


    }



}
