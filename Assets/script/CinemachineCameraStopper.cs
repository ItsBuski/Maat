using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemachineCameraStopper : MonoBehaviour
{
    [SerializeField] float cameraLimitXmax;
    [SerializeField] float cameraLimitXmin;

    [SerializeField] float cameraLimitYmax;
    [SerializeField] float cameraLimitYmin;

    GameObject camera;
    void Start()
    {
        
    }

    
    void Update()
    {
        camera.SetActive(false);
        if (transform.position.x > cameraLimitXmax)
        {
            camera.SetActive(true);
        }
        if (transform.position.x < cameraLimitXmin)
        {
            camera.SetActive(true);
        }
        if (transform.position.y > cameraLimitYmax)
        {
            camera.SetActive(true);
        }
        if (transform.position.y < cameraLimitYmin)
        {
            camera.SetActive(true);
        }
    }
}
