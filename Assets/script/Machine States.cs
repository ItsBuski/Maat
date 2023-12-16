using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatesMachine : MonoBehaviour
{
    [SerializeField] MonoBehaviour[] playerScripts;
    public PlayerStats damageDealer;
    bool lostHealth = false;
    PlayerJump CanDoubleJump;
    int random;
    void Update()
    {  
        if (lostHealth == true)
        {
            random = Random.Range(0, playerScripts.Length); 
            if (playerScripts[random] is PlayerJump) {
                CanDoubleJump.CanDoubleJump = false;
            }
            else
            {
                playerScripts[random].enabled = false;
            }
        }   
    }
    public void LostHealth()
    {   
        if (damageDealer != null)
        {
            lostHealth = true;
        }
    }
}   