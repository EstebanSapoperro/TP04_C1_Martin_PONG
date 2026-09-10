using TMPro;
using UnityEngine;

public class WinPanel : MonoBehaviour
{

    [SerializeField] private TMP_Text winsP1Counter;
    [SerializeField] private TMP_Text winsP2Counter;
    [SerializeField] private TMP_Text deadRason;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void DeadRason(string rason, string playerdead) 
    {
       deadRason.text = "The player " + playerdead + "die by " + rason;
       winsP1Counter.text = GameManagerPONG.Stats.p1Wins.ToString();
       winsP2Counter.text = GameManagerPONG.Stats.p2Wins.ToString();
    }
}
