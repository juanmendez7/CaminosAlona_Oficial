using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aristarco : MonoBehaviour
{
    public List<AudioClip> audioClips;  // Lista de clips de audio a reproducir
    private AudioSource audioSource;    // Componente AudioSource
    private int currentClipIndex = 0;   // Índice del clip de audio actual
    public float pauseDuration = 5.0f;  // Duración de la pausa entre clips de audio

    private Animator animator;  // Componente Animator

    void Start()
    {
        // Obtén el componente AudioSource del GameObject
        audioSource = GetComponent<AudioSource>();

        // Obtén el componente Animator del GameObject (o del personaje)
        animator = GetComponent<Animator>();

        // Configurar el AudioSource para 3D
        audioSource.spatialBlend = 1.0f;  // 3D audio
        audioSource.rolloffMode = AudioRolloffMode.Logarithmic;  // Modo de atenuación logarítmica
        audioSource.minDistance = 1.0f;  // Distancia mínima
        audioSource.maxDistance = 50.0f;  // Distancia máxima (ajústalo según tus necesidades)

        // Comienza la reproducción del primer clip de audio
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

            // Cambia la animación basada en el índice actual
            animator.SetInteger("AnimIndex", currentClipIndex % 3);  // Asumiendo 3 animaciones

            // Espera hasta que el clip de audio termine
            yield return new WaitForSeconds(audioSource.clip.length);

            // Incrementa el índice para el próximo clip
            currentClipIndex++;

            // Espera por la duración de la pausa
            yield return new WaitForSeconds(pauseDuration);
        }

        // Vuelve a la primera animación después de que todos los clips se hayan reproducido
        animator.SetInteger("AnimIndex", 0);
    }
}
