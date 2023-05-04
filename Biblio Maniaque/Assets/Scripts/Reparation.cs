using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Reparation : MonoBehaviour
{
    public GameObject livre;
    public GameObject ranger;
    public GameObject Casser01;
    public GameObject Casser02;
    public GameObject Casser03;
    public GameObject Réparer01;
    public GameObject Réparer02;
    public GameObject Réparer03;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null && CompareTag("Reparation"))
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }


}
