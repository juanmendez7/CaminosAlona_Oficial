using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumeroAleatorio : MonoBehaviour
{
  public TextMeshProUGUI textoResultado;

   public int numeroAleatorio;


    public void GenerarNumeroAleatorio()
    {
        // Genera un número aleatorio entre 1 y 20
       numeroAleatorio = Random.Range(0, 20);

        // Muestra el número aleatorio en el TextMeshPro
        textoResultado.text = "Número: " + numeroAleatorio;
    }
}
