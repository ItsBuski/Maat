 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinchis : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si la colisi�n involucra al jugador
        if (collision.collider.CompareTag("Player"))
        {
            // Aqu� puedes poner el c�digo que deseas ejecutar cuando hay una colisi�n con el jugador
            Debug.Log("Colisi�n con el jugador");
            player.GetComponent<PlayerStats>().TakeDamage(1);
        }
    }
}
