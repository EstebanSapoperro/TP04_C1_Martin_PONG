using UnityEngine;


[CreateAssetMenu(fileName = "VoidData", menuName = "Game/Data/Void")]
public class VoidDataSo : ScriptableObject
{
    [Header("CountDown")]
    public float countPriWarning = 3;
    public float countSecWarning = 2;
    public float countTreWarning = 1;

    public float minbasecooldown = 6;
    public float maxbasecooldown = 8;


    [Header("ColorCountDown")]
    public Color priWarningColor;
    public Color secWarningColor;
    public Color treWarningColor;
    public Color baseColor;

}
