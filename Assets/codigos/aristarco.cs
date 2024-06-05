using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aristarco : MonoBehaviour
{
    public List<AudioClip> audioClips;  // Lista de clips de audio a reproducir
    private AudioSource audioSource;    // Componente AudioSource
    private int currentClipIndex = 0;   // �ndice del clip de audio actual
    public float pauseDuration = 5.0f;  // Duraci�n de la pausa entre clips de audio

    private Animator animator;  // Componente Animator

    void Start()
    {
        // Obt�n el componente AudioSource del GameObject
        audioSource = GetComponent<AudioSource>();

        // Obt�n el componente Animator del GameObject (o del personaje)
        animator = GetComponent<Animator>();

        // Configurar el AudioSource para 3D
        audioSource.spatialBlend = 1.0f;  // 3D audio
        audioSource.rolloffMode = AudioRolloffMode.Logarithmic;  // Modo de atenuaci�n logar�tmica
        audioSource.minDistance = 1.0f;  // Distancia m�nima
        audioSource.maxDistance = 50.0f;  // Distancia m�xima (aj�stalo seg�n tus necesidades)

        // Comienza la reproducci�n del primer clip de audio
        StartCoroutine(PlayNextClip());
    }

    IEnumerator PlayNextClip()
    {
        while (currentClipIndex < audioClips.Count)
        {
            // Asigna el siguiente clip de audio al AudioSource
            audioSource.clip = audioClips[currentClipIndex];

            // Reproduce el clip de audio
            audioSource.Play();

            // Cambia la animaci�n basada en el �ndice actual
            animator.SetInteger("AnimIndex", currentClipIndex % 3);  // Asumiendo 3 animaciones

            // Espera hasta que el clip de audio termine
            yield return new WaitForSeconds(audioSource.clip.length);

            // Incrementa el �ndice para el pr�ximo clip
            currentClipIndex++;

            // Espera por la duraci�n de la pausa
            yield return new WaitForSeconds(pauseDuration);
        }

        // Vuelve a la primera animaci�n despu�s de que todos los clips se hayan reproducido
        animator.SetInteger("AnimIndex", 0);
    }
}
