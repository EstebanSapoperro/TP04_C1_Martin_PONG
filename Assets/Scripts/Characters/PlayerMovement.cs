using Unity.Android.Gradle.Manifest;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerDataSo data;
    public Rigidbody2D rb;
    

    [SerializeField] private SpriteRenderer ActualColor;
    private bool movingUp = false;
    private bool movingDown = false;
    private bool movingRight = false;
    private bool movingLeft = false;
    public bool isPlayerOne;
    public float velocity = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isPlayerOne = data.isPlayeOne;
        velocity = data.velocity;
        ActualColor = GetComponent<SpriteRenderer>();
        Debug.Log("listo para moverme, , yes sir");
    }  

    void Update()
    {
        if (Input.GetKey(data.upInput))
            movingUp = true;
        else movingUp = false;

        if (Input.GetKey(data.downInput))
            movingDown = true;
        else movingDown = false;

        if (Input.GetKey(data.rightInput))
            movingRight = true;
        else movingRight = false;

        if (Input.GetKey(data.leftInput))
            movingLeft = true;
        else movingLeft = false;

        if (isPlayerOne == true) 
        {
            GameManagerPONG.Stats.p1movingDown = movingDown;
            GameManagerPONG.Stats.p1movingUp = movingUp;
            GameManagerPONG.Stats.p1movingLeft = movingLeft;
            GameManagerPONG.Stats.p1movingRight = movingRight;
        }
        if (isPlayerOne == false)
        {
            GameManagerPONG.Stats.p2movingDown = movingDown;
            GameManagerPONG.Stats.p2movingUp = movingUp;
            GameManagerPONG.Stats.p2movingLeft = movingLeft;
            GameManagerPONG.Stats.p2movingRight = movingRight;
        }

    }
    private void FixedUpdate()
    {
        if (movingRight)
            if (rb.linearVelocityX < 0)
                rb.AddForceX(velocity * data.yawMulty);
            else rb.AddForceX(data.velocity);


        if (movingLeft)
            if (rb.linearVelocityX > 0)
                rb.AddForceX(-velocity * data.yawMulty);
            else rb.AddForceX(-velocity);


        if (movingUp)
            if (rb.linearVelocityY < 0)
                rb.AddForceY(velocity * data.yawMulty);
            else rb.AddForceY(velocity);

        if (movingDown)
            if (rb.linearVelocityY > 0)
                rb.AddForceY(-velocity * data.yawMulty);
            else rb.AddForceY(-velocity);

        if (movingRight == false && movingLeft == false)
        {
            rb.linearVelocityX += -rb.linearVelocityX * data.friction;
        }

        if (movingUp == false && movingDown == false)
        {
            rb.linearVelocityY += -rb.linearVelocityY * data.friction;
        }



    }

}
