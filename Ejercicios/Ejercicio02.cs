using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    /*---- Mejorá el código  ----*/

    //Dato:no se que es,pero siento que algo no esta bien.

    int force;
    int agility;

    private void Start()
    {
        force = 100;
        agility = 50;
    }
    
    private void SpecialAttack()
    {
        bool isForceSpecial = (force * 2) / 5 > -1
        bool isAgility = (agility / 2 > 20)

        If (isForceSpecial && isAgility) Debug.Log("Special Attack Activate");
        
    }
}
