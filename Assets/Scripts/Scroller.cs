using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float Speed;
    public float FlipOnY;
    public float TopPosition;
    public GameObject Obstacles;
    public GameObject Pedestrians;
    public GameObject Stone;
    public GameObject StandingPedestrian;
    public GameObject PotHole7;
    public GameObject PotHole8;
    void Update(){
        gameObject.transform.position -= new Vector3(0f, Speed, 0f) * Time.deltaTime;
        if(gameObject.transform.position.y < FlipOnY){
            // Remove all Pedestrians and obstacles
            destroyAllObstacles();    
            destroyAllPedestrians();
            
            // Move the background to the top position
            gameObject.transform.position = new Vector3(0f, TopPosition, 0f);
           
            // Spawn new Pedestrian and obstacles
            spawnObstaclesAndPedestrians();
        }
    }

    private void spawnObstaclesAndPedestrians(){
        float minYPos = -5.0f+11f;
        float maxYPos = 4.0f+11f;
        float minXPos = -1.2f;
        float maxXPos = 1.2f;

        Instantiate(PotHole7, new Vector3(minXPos, minYPos, 0f), Quaternion.identity, Obstacles.transform);
        Instantiate(PotHole8, new Vector3(maxXPos, maxYPos, 0f), Quaternion.identity, Obstacles.transform);
    }
    private void destroyAllObstacles(){
        foreach (Transform child in Obstacles.transform) {
            GameObject.Destroy(child.gameObject);
        }
    }
    private void destroyAllPedestrians(){
        foreach (Transform child in Pedestrians.transform) {
            GameObject.Destroy(child.gameObject);
        }
    }
}
