using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumeroAleatorio : MonoBehaviour
{
  public TextMeshProUGUI textoResultado;

    public void GenerarNumeroAleatorio()
    {
        // Genera un número aleatorio entre 1 y 20
        int numeroAleatorio = Random.Range(1, 21);

        // Muestra el número aleatorio en el TextMeshPro
        textoResultado.text = "Número: " + numeroAleatorio;
    }
}
