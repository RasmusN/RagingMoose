using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    PlayerInfo playerInfo;
    Text scoreText, distanceText;
    Transform scoreChild, distanceChild;

    void Start()
    {
        playerInfo = PlayerInfo.FindObjectOfType<PlayerInfo>();

        // get score text and distance text
        scoreChild = transform.Find("FinalScoreTxt");
        scoreText = scoreChild.GetComponent<Text>();
        distanceChild = transform.Find("DistanceTxt");
        distanceText = distanceChild.GetComponent<Text>();

        // change text
        if(playerInfo == null)
        {
            scoreText.text = "Final Score: " + 0;
            distanceText.text = "Distance: " + 0;
            return;
        }
        scoreText.text = "Final Score: " + playerInfo.Score;
        distanceText.text = "Distance: " + playerInfo._distanceLeft;

    }
}
