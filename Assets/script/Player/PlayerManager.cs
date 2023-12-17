using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public Transform player;
    public Transform A1Point;
    public Transform B1Point;
    public Transform C1Point;
    public Transform A2Point;
    public Transform B2Point;
    public Transform C2Point;
    public Transform A3Point;
    public Transform B3Point;
    public Transform A4Point;

    void Awake()
    {
        string lastPoint = PlayerPrefs.GetString("Trigger");
        switch (lastPoint) {
            case "1A":
                player.position = A1Point.position;
            break;
            case "1B":
                player.position = B1Point.position;
            break;
            case "1C":
                player.position = C1Point.position;
            break;
            case "2A":
                player.position = A2Point.position;
            break;
            case "2B":
                player.position = B2Point.position;
            break;
            case "2C":
                player.position = C2Point.position;
            break;
            case "3A":
                player.position = A3Point.position;
            break;
            case "3B":
                player.position = B3Point.position;
            break;
            case "4A":
                player.position = A4Point.position;
            break;
        }
    }
}