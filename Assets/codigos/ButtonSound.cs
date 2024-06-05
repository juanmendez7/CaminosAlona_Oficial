using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioClip hoverSound; // El sonido que se reproducir� cuando el mouse pase por encima del bot�n
    private AudioSource audioSource;

    private void Start()
    {
        // Aseg�rate de que hay un AudioSource en el mismo GameObject que este script
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverSound != null)
        {
            audioSource.PlayOneShot(hoverSound);
        }
    }
}
