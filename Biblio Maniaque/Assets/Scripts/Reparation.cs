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
    public GameObject R�parer01;
    public GameObject R�parer02;
    public GameObject R�parer03;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null && CompareTag("Reparation"))
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }


}
