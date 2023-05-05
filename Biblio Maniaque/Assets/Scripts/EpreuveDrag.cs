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
        if (trou == epreuve.nombre)
        {
            reussi++;
            verif.verifTest();
        }
    }
}
