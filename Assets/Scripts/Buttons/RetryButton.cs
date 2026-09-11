using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{
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
        GameManagerPONG.Stats.inTrasition = false;
        GameManagerPONG.Stats.p1Win = false;
        GameManagerPONG.Stats.p2Win = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
