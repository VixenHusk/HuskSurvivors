using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//testing
public class EnemyFollow : MonoBehaviour
{
    public Transform objetivo;  // El objetivo hacia el que se moverá el GameObject
    public float velocidadMovimiento = 5f;  // Velocidad de movimiento

    void Update()
    {
        // Verificar si el objetivo existe y moverse hacia él
        if (objetivo != null)
        {
            MoverHaciaObjetivo();
        }
    }

    void MoverHaciaObjetivo()
    {
        // Calcular la dirección hacia el objetivo
        Vector3 direccion = (objetivo.position - transform.position).normalized;

        // Calcular la nueva posición
        Vector3 nuevaPosicion = transform.position + direccion * velocidadMovimiento * Time.deltaTime;

        // Mover el GameObject hacia el objetivo
        transform.position = nuevaPosicion;
    }
}

