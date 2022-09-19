using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    /*---- Mejora el Switch ----*/

    //Dato: como podriamos hacer para no usar tantos "if"?

    string action;
    int hability;

    void start 
    {
        action ;
        hability = 1;
    }
    void StartAction()
    {
        switch (hability)
        {
            case 1:
                action = "Heal"; 
                Debug.Log("Me curé");             
                break;

            case 2:
                action = "Attack";
                Debug.Log("Hago daño");
                break;

            case 3:
                action = "Special Attack";
                Debug.Log("Empiezo a girar como trompo");
                break;
         
        }
    }
}
}
