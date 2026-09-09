using Unity.VisualScripting;
using UnityEngine;

public class SlamMechanic : MonoBehaviour
{
    private float limits = 11.0f;
    private Vector3 position;
    private float teleportRadius = 9.0f;
    private void FixedUpdate()
    {
        if (transform.localPosition.x < -limits) 
        {
            Vector3 posicion = transform.localPosition;
            posicion.x = teleportRadius;
            transform.localPosition = posicion;
        }

        if (transform.localPosition.x > limits)
        {
            Vector3 posicion = transform.localPosition;
            posicion.x = -teleportRadius;
            transform.localPosition = posicion;
        }
    }


}
