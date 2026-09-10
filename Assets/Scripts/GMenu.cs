using UnityEngine;

public class UIGMenu : MonoBehaviour
{

    [SerializeField] private KeyCode Pause = KeyCode.Escape;
    [SerializeField] private GameObject Pausepanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(Pause) && Time.timeScale == 0)
        {
            Time.timeScale = 1;

        }
        else if (Input.GetKeyDown(Pause) && Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(Pause))
        {
            Pausepanel.SetActive(!Pausepanel.activeSelf);
        }
    }
}
