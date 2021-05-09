using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPDisplay : MonoBehaviour
{
    public Text HPText;
    PlayerInfo playerInfo;

    void Start()
    {
        playerInfo = PlayerInfo.FindObjectOfType<PlayerInfo>();
    }
    // Update is called once per frame
    void Update()
    {
        if(playerInfo.Hp <= 0)
        {
            HPText.text = "" + 0;
            SceneManager.LoadScene(2);
        }
        else
        {
            HPText.text = "" + playerInfo.Hp;
        }
    }
}
