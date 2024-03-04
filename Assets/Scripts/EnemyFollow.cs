using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//testing
public class EnemyFollow : MonoBehaviour
{
    public Transform objetivo;  // El objetivo hacia el que se mover� el GameObject
    public float velocidadMovimiento = 5f;  // Velocidad de movimiento

    void Update()
    {
        // Verificar si el objetivo existe y moverse hacia �l
        if (objetivo != null)
        {
            MoverHaciaObjetivo();
        }
    }

    void MoverHaciaObjetivo()
    {
        // Calcular la direcci�n hacia el objetivo
        Vector3 direccion = (objetivo.position - transform.position).normalized;

        // Calcular la nueva posici�n
        Vector3 nuevaPosicion = transform.position + direccion * velocidadMovimiento * Time.deltaTime;

        // Mover el GameObject hacia el objetivo
        transform.position = nuevaPosicion;
    }
}

