using UnityEngine;
using UnityEngine.UI;



public class EnterbackButton : MonoBehaviour
{
    [SerializeField] private bool IsResumeButton = false;
    [SerializeField] private GameObject Enterpanel;
    [SerializeField] private GameObject Exitpanel;

    [SerializeField] private Button Exitbutton;
    private void Awake()
    {


        Exitbutton.onClick.AddListener(onClick);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }



    private void OnDestroy()
    {
        Exitbutton.onClick.RemoveAllListeners();
    }
    // Update is called once per frame

    private void onenter()
    {

    }
    private void onClick()
    {


        if (IsResumeButton == true)
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;

            }
            else if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }

        }
        if (Enterpanel != null)
        {
            Enterpanel.SetActive(true);
        }

        Exitpanel.SetActive(false);

    }

}
