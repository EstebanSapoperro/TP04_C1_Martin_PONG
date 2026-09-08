using UnityEngine;
using TMPro;
public class TimeCount : MonoBehaviour
{
    private float baseTime = 20.0f;
    [SerializeField] private TextMeshProUGUI counter;
    private float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = baseTime;
    }
    private void Update()
    {
        time -= Time.deltaTime;
        counter.text = time.ToString("F1");
    }

}
