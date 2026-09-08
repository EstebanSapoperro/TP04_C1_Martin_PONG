using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("El mouse entró al botón");

        transform.localScale += Vector3.one;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("El mouse salió del botón");

        transform.localScale -= Vector3.one;
    }
}
