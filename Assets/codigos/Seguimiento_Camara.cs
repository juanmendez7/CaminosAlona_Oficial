using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento_Camara : MonoBehaviour
{
    public List<GameObject> personajes; // Lista de personajes
    private Transform objetivo; // El objetivo a seguir

    public float suavidad = 0.125f; // Suavidad del seguimiento
    public Vector3 offset; // Desplazamiento de la cámara respecto al objetivo

    void Start()
    {
        // Encuentra y sigue al personaje activo al inicio
        BuscarPersonajeActivo();
    }

    void Update()
    {
        // Verifica si el personaje objetivo sigue siendo el activo
        if (objetivo == null || !objetivo.gameObject.activeInHierarchy)
        {
            BuscarPersonajeActivo();
        }
    }

    void LateUpdate()
    {
        if (objetivo != null)
        {
            Vector3 posicionDeseada = objetivo.position + offset;
            Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, suavidad);
            transform.position = posicionSuavizada;
        }
    }

    void BuscarPersonajeActivo()
    {
        foreach (GameObject personaje in personajes)
        {
            if (personaje.activeInHierarchy)
            {
                objetivo = personaje.transform;
                break;
            }
        }
    }
}
