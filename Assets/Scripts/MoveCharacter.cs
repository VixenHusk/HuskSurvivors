using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    //Declaro la variable de tipo RigidBody que luego asociaremos a nuestro Jugador
    private Rigidbody rb;

    //Declaro la variable pública velocidad para poder modificarla desde la Inspector window
    [Range(1, 10)]
    public float velocidad = 8;

    void Start()
    {

        //Capturo el rigidbody del jugador al iniciar el juego
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);

        // Verificar si no se está presionando ninguna tecla de movimiento
        if (Mathf.Approximately(movimiento.magnitude, 0.0f))
        {
            // Detener el movimiento estableciendo la velocidad a cero
            rb.velocity = Vector3.zero;
        }
        else
        {
            // Aplicar la velocidad directamente sin inercia
            rb.velocity = movimiento * velocidad;
        }
    }
}

