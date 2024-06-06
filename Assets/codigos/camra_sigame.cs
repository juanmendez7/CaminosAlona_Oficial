using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camra_sigame : MonoBehaviour
{
    public Transform target; // El personaje al que la c�mara seguir�
    public Vector3 offset; // El desplazamiento de la c�mara respecto al personaje
    public float smoothSpeed = 0.125f; // La velocidad de suavizado de la c�mara

    private void LateUpdate()
    {
        // Calcula la posici�n deseada de la c�mara
        Vector3 desiredPosition = target.position + target.rotation * offset;

        // Suaviza la transici�n de la c�mara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Actualiza la posici�n de la c�mara
        transform.position = smoothedPosition;

        // Asegura que la c�mara mire al objetivo
        transform.LookAt(target);
    }
}
