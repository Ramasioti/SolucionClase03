using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    /*---- Busca otra alternativa ----*/

    /*Dato:Queremos saber si existe el nombre de un enemigo dentro de una lista.
      Podriamos mejorarlo usando algun m�todo de Linq.
    */

    public List<string> enemigos;
    string enemigo;

    private void start()
    {
        enemigos = new List<string>() { "Orco", "Ara�a", "Golem", "Goblin" };
        enemigo = ara�a;
    }


    string EncontrandoEnemigo()
    {
        for (int i = 0; i < enemigos.Length; i++)
        {
            if (enemigos[i].Equals("Ara�a"))
            {
                return "Se Encontro Ara�a";
            }
        }

        return "No se encontr�";


    }
}
