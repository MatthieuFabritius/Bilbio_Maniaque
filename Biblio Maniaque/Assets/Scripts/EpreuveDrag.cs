using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EpreuveDrag : MonoBehaviour, IDropHandler
{
    public int trou;
    public Epreuve epreuve;
    public int reussi = 0;
    public Verif verif;
    public GameObject bon;
    public GameObject mauve;
    public int timer;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Verifa();
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            
        }
    }
    public void Verifa()
    {
        if (trou == epreuve.nombre)
        {
            reussi++;
            verif.verifTest();
            bon.gameObject.SetActive(true);
            feed();
        }
        else
        {
            mauve.gameObject.SetActive(true);
            feed();
        }

    }

    public void feed()
    {
        if (timer == 1)
        {
            bon.gameObject.SetActive(false);
            mauve.gameObject.SetActive(false);
            timer = 0;
        }
        else
        {
            timer++;
        }
    }
}
