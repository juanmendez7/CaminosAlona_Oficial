using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camra_sigame : MonoBehaviour
{
    public Transform target; // El personaje al que la cámara seguirá
    public Vector3 offset; // El desplazamiento de la cámara respecto al personaje
    public float smoothSpeed = 0.125f; // La velocidad de suavizado de la cámara

    private void LateUpdate()
    {
        // Calcula la posición deseada de la cámara
        Vector3 desiredPosition = target.position + target.rotation * offset;

        // Suaviza la transición de la cámara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Actualiza la posición de la cámara
        transform.position = smoothedPosition;

        // Asegura que la cámara mire al objetivo
        transform.LookAt(target);
    }
}
