using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject gameOver;
    

    public void GameOverT()
    {
        gameOver.SetActive(true);
    }
}
