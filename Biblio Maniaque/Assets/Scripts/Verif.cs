using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif : MonoBehaviour
{
    public int nReussi;
    public EpreuveDrag epreuveDrag;
    public GameObject bouton;
    public GameObject drag;

    public void verifTest()
    {
        if (epreuveDrag.reussi == nReussi)
        {
            drag.gameObject.SetActive(false);
            bouton.gameObject.SetActive(true);
        }
    }
}
