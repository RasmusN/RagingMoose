using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceLeftDisplay : MonoBehaviour
{
    public Text DistanceLeftText;
    PlayerInfo playerInfo;

    void Start()
    {
        playerInfo = PlayerInfo.FindObjectOfType<PlayerInfo>();
    }
    // Update is called once per frame
    void Update()
    {
        DistanceLeftText.text = string.Format("{0:0}", playerInfo.DistanceLeft) + " km";
        // DistanceLeftText.text = $"{playerInfo.DistanceLeft} km";
    }
}

