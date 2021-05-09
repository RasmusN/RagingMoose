using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour{
    public int PedestrianHitScore = 150;
    public int HpLostOnHitObstacle = 1;
    public GameObject PlayerInfo;
    public GameObject FlyingPedestrians;
    private PlayerInfo playerInfo;

    void Start(){
        playerInfo = PlayerInfo.GetComponent<PlayerInfo>();
    }
    private void OnTriggerStay2D(Collider2D other){
        if(other.tag.Equals("Forest")){
            playerInfo.Score -= 1;
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if(other.tag.Equals("Forest")){
           playerInfo.Speed = playerInfo.DefaultRoadSpeed; 
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag.Equals("Standing Pedestrian")){
            Debug.Log("Hit a Standing Pedestrian");
            playerInfo.Score += PedestrianHitScore; 
            other.transform.SetParent(FlyingPedestrians.transform);

            float leftOrRight = Math.Sign(other.transform.position.x);
            other.GetComponent<Rigidbody2D>().velocity = new Vector3(leftOrRight*5f, 2f, 0f);
            other.GetComponent<Rigidbody2D>().angularVelocity = 720f;
            Destroy(other.transform.gameObject, 5f);
        } else if(other.tag.Equals("Obstacle")){
            Debug.Log("Hit an obstacle");
            playerInfo.Hp -= HpLostOnHitObstacle;
        } else if(other.tag.Equals("Wall")){
            Debug.Log("Hit the wall");
            playerInfo.Hp = 0;
        } else if (other.tag.Equals("Forest")){
            playerInfo.Speed = playerInfo.DefaultOffRoadSpeed;
        }

        else{
            Debug.Log($"Hit an unknown object TAG #{other.tag}");
        }
    }
}
