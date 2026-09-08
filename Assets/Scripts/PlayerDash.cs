using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private KeyCode dashInput = KeyCode.Q;
    [SerializeField] private float dashMulty = 20.0f;
    [SerializeField] private float baseCooldownOfDash = 3.0f;
    private float cooldownOfDash;
    private bool dashAction = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cooldownOfDash = baseCooldownOfDash;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(dashInput))
        {
            Debug.Log("se tomo el input");
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
        Debug.Log("dasheo");
        rb.linearVelocityY = rb.linearVelocityY * dashMulty;
        rb.linearVelocityX = rb.linearVelocityX * dashMulty;
        cooldownOfDash = baseCooldownOfDash;
    }

}
