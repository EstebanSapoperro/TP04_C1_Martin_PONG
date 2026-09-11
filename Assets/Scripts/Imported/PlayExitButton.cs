using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayExitButton : MonoBehaviour
{

    [SerializeField] private bool playButton = false;
    [SerializeField] private bool mainMenuButton = false;
    [SerializeField] private bool finalMainMenuButton = false;
    [SerializeField] private bool exitButton = false;

    [SerializeField] private Button buttonSelected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {

        buttonSelected.onClick.AddListener(onClick);

    }


    private void OnDestroy()
    {

        buttonSelected.onClick.RemoveAllListeners();

    }


    private void onClick()
    {
        if (mainMenuButton)
        {
            Time.timeScale = 0.0f;
            SceneManager.LoadScene("MainMenu");
        }

        if (playButton)
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("SampleScene");
        }

        if (finalMainMenuButton)
        {
            GameManagerPONG.Stats.machTime = GameManagerPONG.Stats.baseMachTime;
            GameManagerPONG.Stats.machWinsCondition = GameManagerPONG.Stats.baseMachWinsCondition;
            GameManagerPONG.Stats.baseModifierRequest = GameManagerPONG.Stats.modifierRequest;
            GameManagerPONG.Stats.p1Win = false;
            GameManagerPONG.Stats.p2Win = false;
            GameManagerPONG.Stats.p1Wins = 0;
            GameManagerPONG.Stats.p2Wins = 0;

            GameManagerPONG.Stats.pONGActive = false;
            GameManagerPONG.Stats.llabActive = false;
            GameManagerPONG.Stats.voidActive = false;
            GameManagerPONG.Stats.didActive = false;
            GameManagerPONG.Stats.notActive = false;
            GameManagerPONG.Stats.bricksActive = false;
            GameManagerPONG.Stats.slamActive = false;
            RandomNumber.ReiniciarNumeros();

            Time.timeScale = 0.0f;
            SceneManager.LoadScene("MainMenu");
        }

        if (exitButton)
        {
            Application.Quit(); // cierra el build
#if UNITY_EDITOR
            // Dentro del editor: detiene el Play
            UnityEditor.EditorApplication.isPlaying = false;
#endif

        }

    }

}
