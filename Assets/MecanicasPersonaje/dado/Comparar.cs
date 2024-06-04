using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Comparar : MonoBehaviour
{
   
    public TextMeshProUGUI textoResultado;
    public Dado dado; // Referencia al script del dado
    public MovimientoPersonaje personaje;

    public MovimientoEnemigo enemigo;
    

    public void CompararNumeros()
    {
        // Obtener el número del dado
        int numeroDelDado = dado.NumeroActual;
         Debug.Log("Número del dado: " + numeroDelDado);

        // Obtener el número aleatorio del script NumeroAleatorio
        NumeroAleatorio scriptNumeroAleatorio = FindObjectOfType<NumeroAleatorio>();
        int numeroAleatorio = scriptNumeroAleatorio.numeroAleatorio;
         Debug.Log("Número aleatorio: " + numeroAleatorio);


        // Comparar los dos números y realizar la lógica deseada
        if (numeroAleatorio < numeroDelDado)
        {
            textoResultado.text = "El número aleatorio es menor que el número del dado.";
            personaje.valorPersonaje =+ 1f;
        }
        else if (numeroAleatorio > numeroDelDado)
        {
            textoResultado.text = "El número aleatorio es mayor que el número del dado.";
            enemigo.valorEnemigo += 1.0f;
        }
        else
        {
            textoResultado.text = "Ambos números son iguales.";
        }
    }
}
