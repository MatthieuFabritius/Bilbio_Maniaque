using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif : MonoBehaviour
{
    public int nReussi;
    public EpreuveDrag epreuveDrag;
    public GameObject bouton;
    public GameObject drag;
    public GameObject texteBon;
    public GameObject texteMauv;

    public void verifTest()
    {
        if (epreuveDrag.reussi == nReussi)
        {
            Debug.Log("FEF");
            drag.gameObject.SetActive(false);
            bouton.gameObject.SetActive(true);
            texteMauv.gameObject.SetActive(false);
            texteBon.gameObject.SetActive(true);
        }
    }
}
