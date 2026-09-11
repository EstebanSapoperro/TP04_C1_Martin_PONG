using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class SliderPartyConfig : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text textCounter;
    [SerializeField] private bool isMachWiningSlider = false;
    [SerializeField] private bool isMachTimeSlider = false;
    [SerializeField] private bool isMachEntitySpawnSlider = false;



    private void Awake()
    {
        slider.onValueChanged.AddListener(Changevalue);
    }

    private void OnDestroy()
    {
        slider.onValueChanged.RemoveAllListeners();
    }

    void Start()
    {
        if (isMachTimeSlider == true)
        {
            slider.value = GameManagerPONG.Stats.machTime;
            textCounter.text = slider.value.ToString();
        }

        if (isMachWiningSlider == true)
        {
            slider.value = GameManagerPONG.Stats.machWinsCondition;
            textCounter.text = slider.value.ToString();
        }

        if (isMachEntitySpawnSlider == true)
        {
            slider.value = GameManagerPONG.Stats.modifierRequest;
            textCounter.text = slider.value.ToString();
        }
    }

    private void Changevalue(float value) 
    {
        if (isMachTimeSlider == true) 
        {
            GameManagerPONG.Stats.machTime = (int)value;
            textCounter.text = value.ToString();
        }

        if (isMachWiningSlider == true)
        {
            GameManagerPONG.Stats.machWinsCondition = (int)value;
            textCounter.text = value.ToString();
        }

        if (isMachEntitySpawnSlider == true)
        {
            GameManagerPONG.Stats.modifierRequest = (int)value;
            textCounter.text = value.ToString();
        }
    }
}
