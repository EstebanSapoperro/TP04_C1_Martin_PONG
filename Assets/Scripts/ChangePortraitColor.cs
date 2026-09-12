using UnityEngine;
using UnityEngine.UI;

public class ChangePortraitColor : MonoBehaviour
{
    [SerializeField] private Image p1Portrait;
    [SerializeField] private Image p2Portrait;
    void Start()
    {
        p1Portrait.color = new Color(GameManager.Config.RP1, GameManager.Config.GP1, GameManager.Config.BP1);
        p2Portrait.color = new Color(GameManager.Config.RP2, GameManager.Config.GP2, GameManager.Config.BP2);

    }

}
