using UnityEngine;

public class AssignAvatar : MonoBehaviour
{
    public Animator animator; // Asigna el Animator en el Inspector o encuentra el componente en el script

    void Start()
    {
        // Busca todos los Avatar que son hijos del objeto vacío
        Avatar[] avatars = GetComponentsInChildren<Avatar>();

        // Si hay avatares y el Animator no tiene un avatar asignado
        if (avatars.Length > 0 && animator != null)
        {
            foreach (Avatar avatar in avatars)
            {
                if (avatar != null) // Asegúrate de que el avatar no es null
                {
                    animator.avatar = avatar;
                    break; // Sal del bucle una vez que encuentres el primer avatar
                }
            }
        }
        else
        {
            Debug.LogError("No avatars found or Animator is not assigned.");
        }
    }
}
