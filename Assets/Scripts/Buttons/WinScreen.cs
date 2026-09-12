using TMPro;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text WiningPanel;
    void Start()
    {
        if (GameManagerPONG.Stats.p1Wins == GameManagerPONG.Stats.machWinsCondition) 
        {
            WiningPanel.text = "Gano el jugador uno";
        }

        if (GameManagerPONG.Stats.p2Wins == GameManagerPONG.Stats.machWinsCondition)
        {
            WiningPanel.text = "Gano el jugador dos";
        }

    }

}
