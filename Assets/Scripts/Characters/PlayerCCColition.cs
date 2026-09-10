using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class PlayerCCColition : MonoBehaviour
{
    [SerializeField] PlayerDataSo data;
    [SerializeField] private GameObject colider;
    private bool isPlayerOne;
    [SerializeField] private SpriteRenderer player;
    [SerializeField] private SpriteRenderer playerCapsule;
    //Player Color Change Colition
    void Start()
    {
        isPlayerOne = data.isPlayeOne;
        if (isPlayerOne)
        {
            colider.transform.localScale = new Vector3 (1, GameManager.Config.YScaleP1, 1);
            playerCapsule.color = new Color(GameManager.Config.RP1, GameManager.Config.GP1, GameManager.Config.BP1);
        }
        else 
        {
            colider.transform.localScale = new Vector3(1, GameManager.Config.YScaleP2, 1);
            playerCapsule.color = new Color(GameManager.Config.RP2, GameManager.Config.GP2, GameManager.Config.BP2);
        }
        

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            player.color = Color.black;
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("Ball"))
        {
            player.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
