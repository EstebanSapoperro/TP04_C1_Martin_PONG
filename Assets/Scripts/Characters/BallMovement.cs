using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] public float Charge = 0.2f;
    public Rigidbody2D rb;
    [SerializeField] private bool ball = true;
    private bool goingUp = false;
    private bool goingRight = false;
    [SerializeField] private float initialMaxVelocity = -3.0f;
    private float maxVelocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (ball)
        {
            maxVelocity = initialMaxVelocity;
            rb.linearVelocityX = initialMaxVelocity; rb.linearVelocityY = initialMaxVelocity;
        }
        else 
        {
            goingRight = true;
            goingUp = true;
            maxVelocity = initialMaxVelocity;
            rb.linearVelocityX = -initialMaxVelocity; rb.linearVelocityY = -initialMaxVelocity;
        }
        
    }
    private void FixedUpdate()
    {
        //sistema de velocidad máxima progresiva
        if (rb.linearVelocityX < -maxVelocity)
        {
            rb.linearVelocityX = -maxVelocity;
        }

        if (rb.linearVelocityX > maxVelocity)
        {
            rb.linearVelocityX = maxVelocity;
        }

        if (rb.linearVelocityY < -maxVelocity)
        {
            rb.linearVelocityY = -maxVelocity;
        }

        if (rb.linearVelocityY > maxVelocity)
        {
            rb.linearVelocityY = maxVelocity;
        }

        //sitema de carga rebotes
        if (rb.linearVelocityX < 0 && goingRight)
        {
            goingRight = false;
            maxVelocity += Charge;
        }

        if (rb.linearVelocityX > 0 && !goingRight)
        {
            goingRight = true;
            maxVelocity += Charge;
        }

        if (rb.linearVelocityY < 0 && goingUp)
        {
            goingUp = false;
            maxVelocity += Charge;
        }

        if (rb.linearVelocityY > 0 && !goingUp)
        {
            goingUp = true;
            maxVelocity += Charge;
        }

    }

}
