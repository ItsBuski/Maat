using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] MonoBehaviour[] playerScripts;
    [SerializeField] Button button;
    void Start()
    {
        
    }

    void Update()
    {
        if (!playerScripts[0].enabled)
        {
            button.enabled = false;
        }
        if (!playerScripts[1].enabled) {
            button.enabled = false;
        }
        if (!playerScripts[2].enabled)
        {
            button.enabled = false;
        }
    }
}
