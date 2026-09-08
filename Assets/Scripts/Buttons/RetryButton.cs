using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
