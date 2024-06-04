using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float groundCheckDistance = 0.1f; // Distancia del raycast para comprobar el suelo

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            // Recoger entradas del usuario
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            // Crear el vector de movimiento basado en las entradas del usuario
            moveDirection = new Vector3(moveX, 0.0f, moveZ);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            // Iniciar animaciones de caminar y estar en reposo
            if (moveDirection != Vector3.zero)
            {
                animator.SetBool("isWalking", true);
            }
            else
            {
                animator.SetBool("isWalking", false);
            }

            // Saltar solo si el personaje está sobre un objeto con el tag "Piso"
            if (Input.GetButton("Jump") && IsGrounded())
            {
                moveDirection.y = jumpSpeed;
                animator.SetTrigger("Jump");
            }
        }

        // Aplicar gravedad
        moveDirection.y -= gravity * Time.deltaTime;

        // Mover el controlador de personajes
        controller.Move(moveDirection * Time.deltaTime);
    }

   bool IsGrounded()
    {
        // Realizar un raycast hacia abajo para comprobar si el personaje está tocando un objeto con el tag "Piso"
        RaycastHit hit;
        Vector3 rayOrigin = transform.position + Vector3.down * controller.height / 2;
        Debug.DrawRay(rayOrigin, Vector3.down * groundCheckDistance, Color.red); // Dibujar el raycast en la escena

        if (Physics.Raycast(rayOrigin, Vector3.down, out hit, groundCheckDistance))
        {
            if (hit.collider.CompareTag("Piso"))
            {
                return true;
            }
        }
        return false;
    }
}
