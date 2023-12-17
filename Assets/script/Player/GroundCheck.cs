using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public LayerMask groundLayer;
    public bool isGrounded;

    void Update()
    {
        // Comprueba si hay colisión con el suelo
        isGrounded = Physics2D.OverlapBox(transform.position, new Vector2(2f, 2f), 0f, groundLayer);
    }

    // Dibuja el gizmo para visualizar el área de comprobación en el editor
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(2f, 2f, 0f));
    }
}