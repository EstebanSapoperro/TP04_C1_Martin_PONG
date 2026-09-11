using TMPro;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    
    [SerializeField] private GameObject roundPanel;
    [SerializeField] private GameObject winingPanel;
    [SerializeField] private TMP_Text winsP1Counter;
    [SerializeField] private TMP_Text winsP2Counter;
    [SerializeField] private TMP_Text deadRason;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void DeadRason(string rason, string playerdead) 
    {
        GameManagerPONG.Stats.inTrasition = true;
       deadRason.text = "El jugador " + playerdead + " murio por " + rason;
       winsP1Counter.text = GameManagerPONG.Stats.p1Wins.ToString();
       winsP2Counter.text = GameManagerPONG.Stats.p2Wins.ToString();
        if ((GameManagerPONG.Stats.p1Wins == GameManagerPONG.Stats.machWinsCondition) || (GameManagerPONG.Stats.p2Wins == GameManagerPONG.Stats.machWinsCondition)) 
        {
            winingPanel.SetActive(true);
            roundPanel.SetActive(false);
        
        }
    }
}
