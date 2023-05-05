using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivreManager : MonoBehaviour
{
    //public Canvas swap;
    public Canvas livre;

    public GameObject Livre1;
    public GameObject Livre2;
    public GameObject Livre3;
    public GameObject Livre4;
    public GameObject Livre5;
    public GameObject Livre6;
    public GameObject Livre7;
    public GameObject Livre8;

    public GameObject boutonLivre1;
    public GameObject boutonLivre2;
    public GameObject boutonLivre3;
    public GameObject boutonLivre4;
    public GameObject boutonLivre5;
    public GameObject boutonLivre6;
    public GameObject boutonLivre7;
    public GameObject boutonLivre8;

    public GameObject epreuve1;
    public GameObject epreuve2;
    public GameObject epreuve3;
    public GameObject epreuve4;
    public GameObject epreuve5;
    public GameObject epreuve6;
    public GameObject epreuve7;
    public GameObject epreuve8;

    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;
    public GameObject Image6;
    public GameObject Image7;
    public GameObject Image8;

    public GameObject Ranger1;
    public GameObject Ranger2;
    public GameObject Ranger3;
    public GameObject Ranger4;
    public GameObject Ranger5;
    public GameObject Ranger6;
    public GameObject Ranger7;
    public GameObject Ranger8;

    public int finition;
    public GameObject fin;

    public void OuvirLivre1()
    {
        livre.gameObject.SetActive(false);
        Livre1.gameObject.SetActive(true);
    }
    public void OuvirLivre2()
    {
        livre.gameObject.SetActive(false);
        Livre2.gameObject.SetActive(true);
    }
    public void OuvirLivre3()
    {
        livre.gameObject.SetActive(false);
        Livre3.gameObject.SetActive(true);
    }
    public void OuvirLivre4()
    {
        livre.gameObject.SetActive(false);
        Livre4.gameObject.SetActive(true);
    }
    public void OuvirLivre5()
    {
        livre.gameObject.SetActive(false);
        Livre5.gameObject.SetActive(true);
    }
    public void OuvirLivre6()
    {
        livre.gameObject.SetActive(false);
        Livre6.gameObject.SetActive(true);
    }
    public void OuvirLivre7()
    {
        livre.gameObject.SetActive(false);
        Livre7.gameObject.SetActive(true); ;
    }
    public void OuvirLivre8()
    {
        livre.gameObject.SetActive(false);
        Livre8.gameObject.SetActive(true);
    }

    public void FermerLivre1()
    {
        epreuve1.gameObject.SetActive(false);
        Image1.gameObject.SetActive(true);
        boutonLivre1.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
    }
    public void FermerLivre2()
    {
        epreuve2.gameObject.SetActive(false);
        Image2.gameObject.SetActive(true);
        boutonLivre2.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
    }
    public void FermerLivre3()
    {
        epreuve3.gameObject.SetActive(false);
        Image3.gameObject.SetActive(true);
        boutonLivre3.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
    }
    public void FermerLivre4()
    {
        epreuve4.gameObject.SetActive(false);
        Image4.gameObject.SetActive(true);
        boutonLivre4.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
    }
    public void FermerLivre5()
    {
        epreuve5.gameObject.SetActive(false);
        Image5.gameObject.SetActive(true);
        boutonLivre5.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
    }
    public void FermerLivre6()
    {
        epreuve6.gameObject.SetActive(false);
        Image6.gameObject.SetActive(true);
        boutonLivre6.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
    }
    public void FermerLivre7()
    {
        epreuve7.gameObject.SetActive(false);
        Image7.gameObject.SetActive(true);
        boutonLivre7.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
    }
    public void FermerLivre8()
    {
        epreuve8.gameObject.SetActive(false);
        Image8.gameObject.SetActive(true);
        boutonLivre8.gameObject.SetActive(true);
        livre.gameObject.SetActive(true);
    }

    public void RangerLivre1()
    {
        Livre1.gameObject.SetActive(false);
        boutonLivre1.gameObject.SetActive(false);
        Ranger1.gameObject.SetActive(true);
        finition++;
    }
    public void RangerLivre2()
    {
        Livre2.gameObject.SetActive(false);
        boutonLivre2.gameObject.SetActive(false);
        Ranger2.gameObject.SetActive(true);
        finition++;
    }
    public void RangerLivre3()
    {
        Livre3.gameObject.SetActive(false);
        boutonLivre3.gameObject.SetActive(false);
        Ranger3.gameObject.SetActive(true);
        finition++;
    }
    public void RangerLivre4()
    {
        Livre4.gameObject.SetActive(false);
        boutonLivre4.gameObject.SetActive(false);
        Ranger4.gameObject.SetActive(true);
        finition++;
    }
    public void RangerLivre5()
    {
        Livre5.gameObject.SetActive(false);
        boutonLivre5.gameObject.SetActive(false);
        Ranger5.gameObject.SetActive(true);
        finition++;
    }
    public void RangerLivre6()
    {
        Livre6.gameObject.SetActive(false);
        boutonLivre6.gameObject.SetActive(false);
        Ranger6.gameObject.SetActive(true);
        finition++;
    }
    public void RangerLivre7()
    {
        Livre7.gameObject.SetActive(false);
        boutonLivre7.gameObject.SetActive(false);
        Ranger7.gameObject.SetActive(true);
        finition++;
    }
    public void RangerLivre8()
    {
        Livre8.gameObject.SetActive(false);
        boutonLivre8.gameObject.SetActive(false);
        Ranger8.gameObject.SetActive(true);
        finition++;
    }

    public void Finits()
    {
        if(finition == 8)
        {
           fin.gameObject.SetActive(true);
        }
    }
}
