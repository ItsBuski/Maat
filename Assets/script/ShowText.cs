using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using TMPro;

public class ShowText : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField] bool buttonPressed;
    [SerializeField] TextMeshProUGUI text;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
    void Update()
    {
        if (buttonPressed)
        {
            text.enabled = true;
        }
        else if(!buttonPressed) {
            text.enabled = false;
        }
    }
}