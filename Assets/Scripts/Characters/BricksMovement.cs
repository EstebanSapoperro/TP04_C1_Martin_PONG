using UnityEngine;

public class BricksMovement : MonoBehaviour
{
    private float limits = 6.0f;
    private Vector3 position;
    private float teleportRadius = 5.0f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocityY = -2.0f;
    }

    private void FixedUpdate()
    {
        if (transform.localPosition.y < -limits)
        {
            Vector3 posicion = transform.localPosition;
            posicion.y = teleportRadius;
            transform.localPosition = posicion;
        }
    }
}
