using UnityEngine;

public class Voidmechanic : MonoBehaviour
{

    [SerializeField] private SpriteRenderer voided;
    private float cooldowntimer = 7.0f;
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        if (cooldowntimer >= 0) 
        {
         cooldowntimer -= Time.deltaTime;
        }
       
    }

}
