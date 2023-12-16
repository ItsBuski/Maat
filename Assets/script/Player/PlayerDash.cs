using System.Collections;

using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class PlayerDash : MonoBehaviour
{
    [SerializeField] float dashDistance;
    [SerializeField] float timer;
    [SerializeField] float timerTime;

    [Header("Events")]
    [Space]

    public UnityEvent OnDashEvent;

    void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.C))
        {
            Dash();
            
        }
        
    }
    void Dash()
    {
     
        if (timer <= 0)
        {
            transform.position = transform.position + new Vector3(Input.GetAxisRaw("Horizontal") * dashDistance, 0, 0);
            Debug.Log("Dash");

            timer = timerTime;
            OnDashEvent.Invoke();
        }

    }
}
