using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epreuve : MonoBehaviour
{
    public int bonneReponse = 0;
    public LivreManager livreManager;
    public int nombreReponse;
    public Reponse reponse;

    public void BonneReponse()
    {
        bonneReponse++;
    }

    public void QCM()
    {
        if (nombreReponse == reponse.reponse)
        {
            BonneReponse();
        }
        else
        {
           
        }
    }

}
