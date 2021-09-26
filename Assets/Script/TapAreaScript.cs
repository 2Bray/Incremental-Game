using UnityEngine;
using UnityEngine.EventSystems;

public class TapAreaScript : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        GameManagerScript.Instance.CollectByTap(eventData.position, transform);
    }
}