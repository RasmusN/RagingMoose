using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    PlayerInfo playerInfo;
    Text scoreText, distanceText, pedestriansTxt, healthTxt;
    Image tryAgainImage;
    Image backgroundImage;
    Image rightColor;
    Image leftColor;
    public AudioSource audioSrc;
    public Sprite loseBtn;
    public Sprite winBtn;
    public Sprite loseBackgroundImg;
    public Sprite winBackgroundImg;
    public Color loseColor;
    public Color rightWinColor;
    public Color leftWinColor;
    public AudioClip loseMusic;

    void Start()
    {
        playerInfo = PlayerInfo.FindObjectOfType<PlayerInfo>();

        // get score text and distance text
        scoreText = transform.Find("Scoreboard").Find("FinalScoreTxt").GetComponent<Text>();
        distanceText = transform.Find("Scoreboard").Find("DistanceTxt").GetComponent<Text>();
        pedestriansTxt = transform.Find("Scoreboard").Find("Pedestrians").GetComponent<Text>();
        healthTxt = transform.Find("Scoreboard").Find("Health").GetComponent<Text>();
        // get button image
        tryAgainImage = transform.Find("Button").GetComponent<Image>();
        // get background image object
        backgroundImage = transform.Find("Background Image").GetComponent<Image>();

        // get background colour objects
        rightColor = transform.Find("Right Color").GetComponent<Image>();
        leftColor = transform.Find("Left Color").GetComponent<Image>();



        if (playerInfo == null)
        {
            return;
        }



        // change text
        if (playerInfo._distanceLeft <= 0)
        {
            distanceText.text = "You reached Kiruna!";
        }
        else
        {
            distanceText.text = "Distance left to Kiruna: " + playerInfo._distanceLeft;
        }
        pedestriansTxt.text = "Pedestrians: " + playerInfo._distanceLeft;
        healthTxt.text = "Health: " + playerInfo.Hp;
        scoreText.text = "Final Score: " + playerInfo.Score;

        // change background image
        if (playerInfo._distanceLeft <= 0)
        {
            backgroundImage.sprite = winBackgroundImg;
        }
        else
        {
            backgroundImage.sprite = loseBackgroundImg;
        }

        // change button image
        if (playerInfo._distanceLeft <= 0)
        {
            tryAgainImage.sprite = winBtn;
        }
        else
        {
            tryAgainImage.sprite = loseBtn;
        }

        // change background colours and audio
        if (playerInfo._distanceLeft <= 0)
        {
            rightColor.color = rightWinColor;
            leftColor.color = leftWinColor;
            audioSrc.clip = loseMusic;
        }
        else
        {
            rightColor.color = loseColor;
            leftColor.color = loseColor;
        }
        

    }
}
