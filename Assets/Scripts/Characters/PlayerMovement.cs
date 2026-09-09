using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField] PlayerDataSo data;
    public Rigidbody2D rb;
    

    [SerializeField] public bool isPlayer1 = true;

    [SerializeField] private SpriteRenderer ActualColor;
    private bool movingUp = false;
    private bool movingDown = false;
    private bool movingRight = false;
    private bool movingLeft = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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


    }
    private void FixedUpdate()
    {
        if (movingRight)
            if (rb.linearVelocityX < 0)
                rb.AddForceX(data.velocity * data.yawMulty);
            else rb.AddForceX(data.velocity);


        if (movingLeft)
            if (rb.linearVelocityX > 0)
                rb.AddForceX(-data.velocity * data.yawMulty);
            else rb.AddForceX(-data.velocity);


        if (movingUp)
            if (rb.linearVelocityY < 0)
                rb.AddForceY(data.velocity * data.yawMulty);
            else rb.AddForceY(data.velocity);

        if (movingDown)
            if (rb.linearVelocityY > 0)
                rb.AddForceY(-data.velocity * data.yawMulty);
            else rb.AddForceY(-data.velocity);

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
