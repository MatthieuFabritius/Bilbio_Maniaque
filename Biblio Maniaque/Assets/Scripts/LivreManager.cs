using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivreManager : MonoBehaviour
{
    public Canvas swap;
    public Canvas livre;
    public GameObject epreuve01;
    public GameObject epreuve02;
    public GameObject epreuve03;
    public GameObject epreuve04;

    public void OuvirLivre21()
    {
        swap.gameObject.SetActive(false);
        livre.gameObject.SetActive(false);
        epreuve01.gameObject.SetActive(true);
    }
    public void OuvirLivre22()
    {
        swap.gameObject.SetActive(false);
        livre.gameObject.SetActive(false);
        epreuve02.gameObject.SetActive(true);
    }
    public void OuvirLivre23()
    {
        swap.gameObject.SetActive(false);
        livre.gameObject.SetActive(false);
        epreuve03.gameObject.SetActive(true);
    }
    public void OuvirLivre24()
    {
        swap.gameObject.SetActive(false);
        livre.gameObject.SetActive(false);
        epreuve04.gameObject.SetActive(true);
    }
    public void FermerLivre21()
    {
        swap.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
        epreuve01.gameObject.SetActive(false);
    }
    public void FermerLivre22()
    {
        swap.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
        epreuve02.gameObject.SetActive(false);
    }
    public void FermerLivre23()
    {
        swap.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
        epreuve03.gameObject.SetActive(false);
    }
    public void FermerLivre24()
    {
        swap.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
        epreuve04.gameObject.SetActive(false);
    }
}
