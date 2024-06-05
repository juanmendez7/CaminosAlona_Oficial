using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    public GameObject funciones;

    // Cambia a la escena especificada por su nombre
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        funciones.GetComponent<CargarPersonaje>().Guardar();
    }

    // Sale de la aplicación
    public void QuitApplication()
    {
        // Si estamos en el editor de Unity, esto no cerrará el editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
