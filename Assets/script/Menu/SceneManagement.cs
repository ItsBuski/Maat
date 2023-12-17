using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] string sceneName;
    private string gameOver;
    [SerializeField] float timer = 0;
    float delayBeforeLoad = 1.5f;
    bool startTimer = false;
    [SerializeField] float transitiontime = 1f;
    public Animator transition;

    private void Awake()
    {
        gameOver = "GameOver";
    }
    private void Update()
    {
        if (startTimer == true && timer <3)
        {
            timer += Time.deltaTime;
            if (timer > delayBeforeLoad)
            {
                Debug.Log("NextScene");
                GoNextScene();
            }
        }
        
    }

    public void GoNextSceneWithTimer()
    {
        startTimer = true;
        transition.SetTrigger("Start");

    }

    public void GoNextScene()
    {
        Debug.Log("NextScene");
        SceneManager.LoadScene(sceneName);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(gameOver);
    }

}
