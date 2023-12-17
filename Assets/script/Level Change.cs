using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerCutscene;
    [SerializeField] float transitiontime = 1f;
    public Animator transition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    void OnTriggerEnter()
    {
        

        if (player.GetComponent<Collider2D>().CompareTag("Warp") || playerCutscene.GetComponent<Collider2D>().CompareTag("Warp"))
        {
           StartCoroutine( LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
    }
    IEnumerator LoadLevel(int levelIndex) 
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(levelIndex);
    }
}

