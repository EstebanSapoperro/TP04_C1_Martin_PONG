using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "Game/Data/Player")]
public class PlayerDataSo : ScriptableObject
{
    [Header("Values of Movement")]
    public float velocity = 6.0f;
    public float yawMulty = 5.0f;
    public float friction = 0.05f;

    [Header("Movement")]
    public KeyCode upInput = KeyCode.W;
    public KeyCode rightInput = KeyCode.D;
    public KeyCode downInput = KeyCode.S;
    public KeyCode leftInput = KeyCode.A;
    public KeyCode dashInput = KeyCode.Q;

    public bool isPlayeOne = true;
}
