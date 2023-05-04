using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpreuveQCM : MonoBehaviour
{
    public int bonneReponse = 0;
    public int nombreReponse;
    public LivreManager livreManager;
    public Reponse reponse;
    public Epreuve epreuves;

    public void BonneReponse()
    {
        bonneReponse++;
    }

    public void QCM()
    {
        if (nombreReponse == quelReponse)
        {
            BonneReponse();
        }
        else
        {
           
        }
    }
    public void FinEpreuve()
    {
        if(bonneReponse = epreuves)
        {

        }

    }

}
