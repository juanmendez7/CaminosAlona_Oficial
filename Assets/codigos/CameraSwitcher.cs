using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras; // Array de cámaras
    public Button leftButton; // Botón de rotación izquierda
    public Button rightButton; // Botón de rotación derecha

    private int currentCameraIndex = 0;

    private void Start()
    {
        // Asigna las funciones de los botones
        leftButton.onClick.AddListener(SwitchLeft);
        rightButton.onClick.AddListener(SwitchRight);

        // Activa la primera cámara y desactiva las demás
        UpdateCameras();
    }

    private void SwitchLeft()
    {
        currentCameraIndex--;
        if (currentCameraIndex < 0)
        {
            currentCameraIndex = cameras.Length - 1;
        }
        UpdateCameras();
    }

    private void SwitchRight()
    {
        currentCameraIndex++;
        if (currentCameraIndex >= cameras.Length)
        {
            currentCameraIndex = 0;
        }
        UpdateCameras();
    }

    private void UpdateCameras()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == currentCameraIndex);
        }
    }
}
