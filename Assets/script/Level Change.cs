using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerCutscene;
    [SerializeField] float transitiontime = 1f;
    public Animator transition;
   
    void OnTriggerEnter2D()
    {
       //if (player.GetComponent<Collider2D>().CompareTag("Warp") || playerCutscene.GetComponent<Collider2D>().CompareTag("Warp"))
        //{
           // Debug.Log("enter");
           //StartCoroutine( LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        //}
    }
    /*IEnumerator LoadLevel(int levelIndex) 
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(levelIndex);
    }*/
}

