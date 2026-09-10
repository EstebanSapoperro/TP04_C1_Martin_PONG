using UnityEngine;

public class PlayerCCColition : MonoBehaviour
{

    [SerializeField] private SpriteRenderer player;
    [SerializeField] private SpriteRenderer playerCapsule;
    //Player Color Change Colition
    void Start()
    {
        playerCapsule.color = new Color(GameManager.Config.RP1, GameManager.Config.GP1, GameManager.Config.BP1);

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
