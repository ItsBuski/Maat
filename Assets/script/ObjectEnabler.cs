using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnabler : MonoBehaviour
{
    [SerializeField] GameObject ObjectToEnable;
    [SerializeField] GameObject textBox;


    
    void OnTriggerEnter2D()
    {
        textBox.SetActive(true);
        ObjectToEnable.SetActive(true);
        
    }
}
