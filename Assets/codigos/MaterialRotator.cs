using UnityEngine;
using UnityEngine.UI;

public class MaterialRotator : MonoBehaviour
{
    public Renderer targetObject; // El objeto cuyo material se va a cambiar
    public Button leftButton; // Botón de rotación izquierda
    public Button rightButton; // Botón de rotación derecha
    public Material[] materials; // Array de materiales por el cual se va a cambiar

    private int currentMaterialIndex = 0;

    private void Start()
    {
        // Asigna las funciones de los botones
        leftButton.onClick.AddListener(RotateLeft);
        rightButton.onClick.AddListener(RotateRight);

        // Inicializa con el primer material
        if (materials.Length > 0 && targetObject != null)
        {
            targetObject.material = materials[currentMaterialIndex];
        }
    }

    private void RotateLeft()
    {
        if (materials.Length == 0) return;

        currentMaterialIndex--;
        if (currentMaterialIndex < 0)
        {
            currentMaterialIndex = materials.Length - 1;
        }
        targetObject.material = materials[currentMaterialIndex];
    }

    private void RotateRight()
    {
        if (materials.Length == 0) return;

        currentMaterialIndex++;
        if (currentMaterialIndex >= materials.Length)
        {
            currentMaterialIndex = 0;
        }
        targetObject.material = materials[currentMaterialIndex];
    }
}
