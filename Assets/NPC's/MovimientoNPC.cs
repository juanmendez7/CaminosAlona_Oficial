using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    public float wanderRadius = 10f;  // Radio dentro del cual el NPC buscará nuevos destinos
    public float wanderInterval = 5f; // Intervalo de tiempo entre búsquedas de nuevos destinos
    private NavMeshAgent agent;
    private Animator animator;

    private float timer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        timer = wanderInterval;
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Si el NPC está cerca de su destino actual
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            // Cambiar a animación de Idle
            animator.SetBool("isWalking", false);

            if (timer >= wanderInterval)
            {
                Vector3 newDestination = RandomNavSphere(transform.position, wanderRadius, -1);
                agent.SetDestination(newDestination);
                timer = 0;
            }
        }
        else
        {
            // Cambiar a animación de Caminar
            animator.SetBool("isWalking", true);
        }
    }

    // Función para encontrar una posición aleatoria en el NavMesh
    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;
        randDirection += origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
        return navHit.position;
    }
}
