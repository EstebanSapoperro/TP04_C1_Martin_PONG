using UnityEngine;

public class DidMechanic : MonoBehaviour
{
    [SerializeField] private float minbasecooldown = 5.0f;
    [SerializeField] private float maxbasecooldown = 8.0f;
    private float cooldowntimer;

    void Start()
    {
        cooldowntimer = Random.Range(minbasecooldown, maxbasecooldown);
    }
    private void FixedUpdate()
    {
        if (cooldowntimer >= -1)
        {
            cooldowntimer -= Time.deltaTime;
        }
    }
}
