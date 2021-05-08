using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour{
    public int PedestrianHitScore = 150;
    public int HpLostOnHitObstacle = 1;
    public GameObject PlayerInfo;
    private PlayerInfo playerInfo;
    void Start(){
        playerInfo = PlayerInfo.GetComponent<PlayerInfo>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag.Equals("Standing Pedestrian")){
            Debug.Log("Hit a Standing Pedestrian");
            playerInfo.Score += PedestrianHitScore; 

        } else if(other.tag.Equals("Obstacle")){
            Debug.Log("Hit an obstacle");
            playerInfo.Hp -= HpLostOnHitObstacle;
        }
        else{
            Debug.Log($"Hit an unknown object TAG #{other.tag}");
        }
    }
}
