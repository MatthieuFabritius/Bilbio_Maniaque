using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivreManager : MonoBehaviour
{
    public Canvas swap;
    public Canvas livre;
    public GameObject epreuve21;
    public GameObject epreuve22;
    public GameObject epreuve23;
    public GameObject epreuve24;

    public void OuvirLivre21()
    {
        swap.gameObject.SetActive(false);
        livre.gameObject.SetActive(false);
        epreuve21.gameObject.SetActive(true);
    }
    public void OuvirLivre22()
    {
        swap.gameObject.SetActive(false);
        livre.gameObject.SetActive(false);
        epreuve22.gameObject.SetActive(true);
    }
    public void OuvirLivre23()
    {
        swap.gameObject.SetActive(false);
        livre.gameObject.SetActive(false);
        epreuve23.gameObject.SetActive(true);
    }
    public void OuvirLivre24()
    {
        swap.gameObject.SetActive(false);
        livre.gameObject.SetActive(false);
        epreuve24.gameObject.SetActive(true);
    }
}
