using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento
        GetComponent<Rigidbody2D>().velocity = new Vector2(playerSpeed * Input.GetAxisRaw("Horizontal"), GetComponent<Rigidbody2D>().velocity.y);
        //  if (Input.GetAxisRaw("Horizontal") == 1) GetComponent<SpriteRenderer>().flipX = false;
        // if (Input.GetAxisRaw("Horizontal") == -1) GetComponent<SpriteRenderer>().flipX = true;


        // Si está sobre una superficie pero se mueve lateralmente
        // if (GetComponent<Rigidbody2D>().velocity.x != 0) SetAnimation("walk");
        // else SetAnimation("idle"); // Si está sobre una superficie pero no se mueve

    }
    /*
        void SetAnimation(string name)
        {

            // Obtenemos todos los parámetros del Animator
            AnimatorControllerParameter[] parametros = GetComponent<Animator>().parameters;

            // Recorremos todos los parámetros y los ponemos a false
            foreach (var item in parametros) GetComponent<Animator>().SetBool(item.name, false);

            // Activamos el pasado por parámetro
            GetComponent<Animator>().SetBool(name, true);

        }
    */
 }


