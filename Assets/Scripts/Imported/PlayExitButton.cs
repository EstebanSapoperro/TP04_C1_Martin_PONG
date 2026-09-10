using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayExitButton : MonoBehaviour
{

    [SerializeField] private bool playButton = false;
    [SerializeField] private bool mainMenuButton = false;
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void onClick()
    {
        if (mainMenuButton)
        {
            Time.timeScale = 0.0f;
            SceneManager.LoadScene("Main Menu");
          

        }
        if (playButton)
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("SampleScene");
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
