using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ModifierButton : MonoBehaviour
{
    [SerializeField] private GameObject modifiersRules;
    [SerializeField] private GameObject Exitpanel;
    [SerializeField] private RulesInfo infoRules;
    private int modifierActivator;

    [SerializeField] private Button Exitbutton;
    private void Awake()
    {
        Exitbutton.onClick.AddListener(onClick);
    }

    private void OnDestroy()
    {
        Exitbutton.onClick.RemoveAllListeners();
    }

    private void onClick()
    {
        if (GameManagerPONG.Stats.actualModifierRequest == GameManagerPONG.Stats.modifierRequest)
        {
            GameManagerPONG.Stats.actualModifierRequest = 0;
            modifierActivator = RandomNumber.ObteinRandomNumber(1, 7);

            if (modifierActivator == 1)
            {
                GameManagerPONG.Stats.llabActive = true;
            }

            if (modifierActivator == 2)
            {
                GameManagerPONG.Stats.slamActive = true;
            }

            if (modifierActivator == 3)
            {
                GameManagerPONG.Stats.voidActive = true;
            }

            if (modifierActivator == 4)
            {
                GameManagerPONG.Stats.didActive = true;
            }

            if (modifierActivator == 5)
            {
                GameManagerPONG.Stats.notActive = true;
            }

            if (modifierActivator == 6)
            {
                GameManagerPONG.Stats.pONGActive = true;
            }

            if (modifierActivator == 7)
            {
                GameManagerPONG.Stats.bricksActive = true;
            }

            if (modifierActivator == -1)
            {
                GameManagerPONG.Stats.inTrasition = false;
                GameManagerPONG.Stats.p1Win = false;
                GameManagerPONG.Stats.p2Win = false;
                Time.timeScale = 1;
                SceneManager.LoadScene("SampleScene");
            }

            if ((modifiersRules != null) && (modifierActivator != -1))
            {
                GameManagerPONG.Stats.inTrasition = false;
                modifiersRules.SetActive(true);
                infoRules.asingEnemy(modifierActivator);
                
                Exitpanel.SetActive(false);
            }


        }

        else
        {
            GameManagerPONG.Stats.inTrasition = false;
            GameManagerPONG.Stats.actualModifierRequest++;
            GameManagerPONG.Stats.p1Win = false;
            GameManagerPONG.Stats.p2Win = false;
            Time.timeScale = 1;
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}
