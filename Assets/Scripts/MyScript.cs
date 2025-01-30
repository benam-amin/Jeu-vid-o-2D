using System;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float monNombreDecimal = 4.5f;
        string maChaine = "Vous ne vous lavez pas ?";
        int[] monTableau  = {0, 5 , 4, 2, 1};
        Debug.Log(monNombreDecimal + " " +  maChaine + " " +  monTableau[4]);
        string Bonjour (string chaine1) {
            return ("Bonjour " + chaine1);
        }
        Debug.Log(Bonjour("Jamy"));
        int Carre(int num) {
            return num * num;
        }
        Debug.Log(Carre(5));
    }

    // Update is called once per frame
    private string maFonction() {
            return ("Tu as cliqué sur le bouton V !");
        }
        
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
    {
        // Mes instructions
        Debug.Log(maFonction());
    }
    }
}
