using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Reparation : MonoBehaviour ,IPointerDownHandler
{
    public GameObject casse;
    public GameObject reparer;
    public GameObject bouton;
    public GameObject scotch;
    public int click;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null && CompareTag("Reparation"))
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            casse.gameObject.SetActive(false);
            reparer.gameObject.SetActive(true);
            bouton.gameObject.SetActive(true);
            scotch.gameObject.SetActive(true);
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if(click == 10)
        {
            casse.gameObject.SetActive(false);
            reparer.gameObject.SetActive(true);
            bouton.gameObject.SetActive(true);
        }
        else
        {
            click++;
        }

    }


}
