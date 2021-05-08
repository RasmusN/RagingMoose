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
    public Sprite[] pedestrianSprites;
    void Update(){
        gameObject.transform.position -= new Vector3(0f, Speed, 0f) * Time.deltaTime;
        if(gameObject.transform.position.y < FlipOnY){
            // Remove all Pedestrians and obstacles
            destroyAllObstacles();    
            
            // Move the background to the top position
            gameObject.transform.position = new Vector3(0f, TopPosition, 0f);
           
            // Spawn new Pedestrians and obstacles
            spawnObstaclesAndPedestrians();
        }
    }

    private void spawnObstaclesAndPedestrians(){
        float minYPos = -5.0f+11f;
        float maxYPos = 4.0f+11f;
        float minXPos = -1.2f;
        float maxXPos = 1.2f;
        float ySpacing = (maxYPos-minYPos)/3f;

        for(int i=0; i<4;i++){
            float yPos = minYPos + i*ySpacing;
            float xPos = Random.Range(minXPos, maxXPos);
            GameObject entity = getRandomEntity();
            if(entity.tag == "Standing Pedestrian"){
                entity.GetComponent<SpriteRenderer>().sprite = pedestrianSprites[Random.Range(0, pedestrianSprites.Length)];
            }
            Instantiate(entity, new Vector3(xPos, yPos, 0f), Quaternion.identity, Obstacles.transform);
        }
    }
    private GameObject getRandomEntity(){
        var objectArray = new GameObject[]{Stone, StandingPedestrian, PotHole7, PotHole8};
        int randomIndex = Random.Range(0, objectArray.Length);
        return objectArray[randomIndex];
    }
    private void destroyAllObstacles(){
        foreach (Transform child in Obstacles.transform) {
            GameObject.Destroy(child.gameObject);
        }
    }
}
