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
        // Verifica si la colisión involucra al jugador
        if (collision.collider.CompareTag("Player"))
        {
            // Aquí puedes poner el código que deseas ejecutar cuando hay una colisión con el jugador
            Debug.Log("Colisión con el jugador");
            player.GetComponent<PlayerStats>().TakeDamage(1);
        }
    }
}
