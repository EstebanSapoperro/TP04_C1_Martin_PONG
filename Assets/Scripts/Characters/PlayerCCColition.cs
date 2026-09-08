using UnityEngine;

public class PlayerCCColition : MonoBehaviour
{

    [SerializeField] private SpriteRenderer player;
    //Player Color Change Colition
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
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
