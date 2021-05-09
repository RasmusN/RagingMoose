using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if(playerInfo._distanceLeft <= 0)
        {
            DontDestroyOnLoad(playerInfo);
            SceneManager.LoadScene(2);
        }
        DistanceLeftText.text = string.Format("{0:0}", playerInfo.DistanceLeft) + " km";
        // DistanceLeftText.text = $"{playerInfo.DistanceLeft} km";
    }
}

