using System.Collections;

using UnityEngine;
using UnityEngine.UIElements;

public class PlayerDash : MonoBehaviour
{
    [SerializeField] float dashDistance;
    [SerializeField] float timer;
    [SerializeField] float timerTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }
        
    }
    void Dash()
    {
     
        if (timer <= 0)
        {
            transform.position = transform.position + new Vector3(Input.GetAxisRaw("Horizontal") * dashDistance, 0, 0);


            timer = timerTime;
        }
        else GetComponent<Rigidbody2D>().gravityScale = 1;

    }
}
