using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// use FindObjectOfType<PlayerInfo>() in Start() of every object that needs this
public class PlayerInfo : MonoBehaviour
{
    public int Hp;
    public int Score;
    public float Speed;

    public void Start()
    {
        Hp = 2;
        Score = 0;
        Speed = 10;
    }
}