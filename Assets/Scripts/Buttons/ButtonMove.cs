using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonMove : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Entró");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Salió");
    }
}
