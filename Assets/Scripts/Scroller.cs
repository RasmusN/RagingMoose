using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float Speed;
    public float FlipOnY;
    public float TopPosition;
    void Update(){
        gameObject.transform.position -= new Vector3(0f, Speed, 0f) * Time.deltaTime;
        if(gameObject.transform.position.y < FlipOnY){
            gameObject.transform.position = new Vector3(0f, TopPosition, 0f);
        }

    }
}
