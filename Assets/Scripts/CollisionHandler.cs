using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag.Equals("Standing Pedestrian")){
            Debug.Log("Hit a Standing Pedestrian");
        } else if(other.tag.Equals("Stone")){
            Debug.Log("Hit a Stone");
        }
        else{
            Debug.Log($"Hit an unknown object TAG #{other.tag}");
        }
    }
}
