using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Reparation : MonoBehaviour , IDropHandler, IPointerDownHandler
{
    public GameObject casse;
    public GameObject reparer;
    public GameObject bouton;
    public GameObject scotch;
    public int click;
    public Epreuve epreuve;
    public int verif;


    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Verifa();
        }
    }
    public void Verifa()
    {
        if (verif == epreuve.nombre)
        {
            casse.gameObject.SetActive(false);
            reparer.gameObject.SetActive(true);
            bouton.gameObject.SetActive(true);
            scotch.gameObject.SetActive(false);
        }
    }
    public void OnPointerDown(PointerEventData evenata)
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
