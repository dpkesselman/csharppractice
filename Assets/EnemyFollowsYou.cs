using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Agregamos la siguiente línea para poder utilizar el sistema de IA de Unity
using UnityEngine.AI;


public class EnemyFollowsYou : MonoBehaviour
{
    public Transform Target; //objeto al que va a perseguir la IA
    public float Speed;
    public NavMeshAgent Enemy; //objeto que va a ser programado con la IA

    void Update()
    {
        Enemy.speed = Speed;
        Enemy.SetDestination(Target.position); //La IA perseguirá la posición de nuestro objeto perseguido
    }
}
