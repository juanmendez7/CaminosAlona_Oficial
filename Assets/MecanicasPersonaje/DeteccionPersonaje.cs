using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteccionPersonaje : MonoBehaviour
{

       public GameObject panel;

       private bool isPaused = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(true);
            isPaused = true;
            Time.timeScale = 0f; // Pausa el juego
        }
    }
}
