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

    public List<string> enemies;
    string enemy;

    private void start()
    {
        enemies = new List<string>() { "Orco", "Ara�a", "Golem", "Goblin" };
        enemy = ara�a;
    }


    string FindingEnemies()
    {

        if(enemies.Contains(enemy)) return "Se Encontro Ara�a";
            

        else return "No se encontr�";


    }
}
