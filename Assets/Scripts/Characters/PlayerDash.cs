using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] PlayerDataSo data;
  
    private float cooldownOfDash;
    private bool dashAction = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cooldownOfDash = data.baseCooldownOfDash;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(data.dashInput))
        {
            dashAction = true;
        }
        else
        {
            dashAction = false;
        }
    }

    private void FixedUpdate()
    {
        if ((dashAction == true) && (cooldownOfDash < 0))
        {
            Dash();
        }

        if (cooldownOfDash > -1)
        {
            cooldownOfDash -= Time.deltaTime;
        }
    }

    private void Dash() 
    {
        rb.linearVelocityY = rb.linearVelocityY * data.dashMulty;
        rb.linearVelocityX = rb.linearVelocityX * data.dashMulty;
        cooldownOfDash = data.baseCooldownOfDash;
    }

}
