using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// use FindObjectOfType<PlayerInfo>() in Start() of every object that needs this
public class PlayerInfo : MonoBehaviour
{
    public int Hp;
    public int Score;
    public float _distanceLeft;
    public float DistanceLeft {get => _distanceLeft; set{
        if(value < 0){
            _distanceLeft = 0;
        } else {
            _distanceLeft = value;
        }
    }}
    public float Speed;
    public float DefaultRoadSpeed;
    public float DefaultOffRoadSpeed;
}
