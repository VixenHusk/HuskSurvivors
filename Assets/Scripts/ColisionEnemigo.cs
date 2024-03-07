using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionEnemigo : MonoBehaviour
{
    public GameObject objetoCanvas;

    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colisionó es el jugador
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);

        }
    }
}
