using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text ScoreText;
    PlayerInfo playerInfo;

    void Start()
    {
        playerInfo = PlayerInfo.FindObjectOfType<PlayerInfo>();
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "" + playerInfo.Score;
    }
}
