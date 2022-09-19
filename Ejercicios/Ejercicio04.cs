using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    /*---- Busca otra alternativa ----*/

    /*Dato:Queremos saber si existe el nombre de un enemigo dentro de una lista.
      Podriamos mejorarlo usando algun método de Linq.
    */

    public List<string> enemies;
    string enemy;

    private void start()
    {
        enemies = new List<string>() { "Orco", "Araña", "Golem", "Goblin" };
        enemy = araña;
    }


    string FindingEnemies()
    {

        if(enemies.Contains(enemy)) return "Se Encontro Araña";
            

        else return "No se encontró";


    }
}
