using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpreuveQCM : MonoBehaviour
{
    public int bonneReponse = 0;
    public GameObject QCM2;
    public LivreManager livreManager;
    public Reponse reponse;
    public Epreuve epreuves;
    public GameObject bouton;
    public GameObject texte;

    public void BonneReponse()
    {
        bonneReponse ++;
    }
    
    public void QCM (int nombreReponse)
    {
        if (nombreReponse == reponse.reponse)
        {
            BonneReponse();
            FinEpreuve();
        }
    }
    public void FinEpreuve()
    {
        if(bonneReponse == epreuves.epreuves)
        {
            QCM2.gameObject.SetActive(false);
            bouton.gameObject.SetActive(true);
            texte.gameObject.SetActive(true);
        }

    }

}
