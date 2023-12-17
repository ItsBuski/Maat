using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatesMachine : MonoBehaviour
{
    [SerializeField] MonoBehaviour[] playerScripts;
    bool lostHealth = false;
    PlayerJump CanDoubleJump;
    int random;
    void Update()
    {
        if (lostHealth)
        {
            random = Random.Range(0, playerScripts.Length);
            if (playerScripts[random] is PlayerJump)
            {
                CanDoubleJump.enabled = false;
            }
            else
            {
                playerScripts[random].enabled = false;
            }

            // Restablece el estado de lostHealth después de realizar las acciones.
            lostHealth = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.GetComponent<DamageDealer>();

        if (damageDealer != null)
        {
            lostHealth = true;
        }
    }
}