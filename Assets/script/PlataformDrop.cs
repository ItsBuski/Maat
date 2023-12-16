using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformDrop : MonoBehaviour
{

    [SerializeField] private float fallDelay = 1f;
    [SerializeField] private float destroyDelay = 5f;
    [SerializeField] private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        gameObject.SetActive(false);
        Destroy(gameObject, destroyDelay);
    }
}
