using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float walkSpeed = 5f; // Velocidad al caminar
    public float runSpeed = 10f; // Velocidad al correr
    public float mouseSensitivity = 100f; // Sensibilidad del mouse

    public float maxEnergy = 10f; // Energía máxima para correr
    public float energyRegenRate = 1f; // Velocidad de regeneración de energía por segundo

    public List<string> collisionTags; // Lista de etiquetas para las colisiones

    private Rigidbody rb;
    private float rotationY = 0f;
    private float currentEnergy;
    private bool isRunning;
    private bool isCollidingWithSpecificTag;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentEnergy = maxEnergy; // Iniciar con energía completa
        Cursor.lockState = CursorLockMode.Locked; // Bloquear el cursor en el centro de la pantalla
    }

    void Update()
    {
        // Obtener la entrada del jugador para el movimiento
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcular el movimiento
        Vector3 movement = transform.right * moveHorizontal + transform.forward * moveVertical;

        // Verificar si el jugador está corriendo, tiene energía y no está colisionando con un objeto de la lista de etiquetas
        if (Input.GetKey(KeyCode.LeftShift) && currentEnergy > 0 && !isCollidingWithSpecificTag)
        {
            isRunning = true;
            currentEnergy -= Time.deltaTime;
            movement *= runSpeed;
        }
        else
        {
            isRunning = false;
            movement *= walkSpeed;
        }

        // Regenerar energía cuando no se está corriendo
        if (!isRunning && currentEnergy < maxEnergy)
        {
            currentEnergy += energyRegenRate * Time.deltaTime;
        }

        // Asegurarse de que la energía no exceda el máximo
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);

        // Aplicar el movimiento
        rb.MovePosition(transform.position + movement * Time.deltaTime);

        // Obtener la entrada del ratón para la rotación
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        // Aplicar la rotación alrededor del eje Y
        rotationY += mouseX;
        Quaternion rotation = Quaternion.Euler(0f, rotationY, 0f);
        transform.rotation = rotation;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collisionTags.Contains(collision.gameObject.tag))
        {
            isCollidingWithSpecificTag = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collisionTags.Contains(collision.gameObject.tag))
        {
            isCollidingWithSpecificTag = false;
        }
    }
}
