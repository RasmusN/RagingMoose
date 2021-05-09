using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    PlayerInfo playerInfo;
    public void menuScene()
    {
        SceneManager.LoadScene(0);
    }
    public void gameScene()
    {
        SceneManager.LoadScene(1);
    }
    public void scoreScene()
    {
        SceneManager.LoadScene(2);
    }
    public void destroyPlayerInfo()
    {
        playerInfo = PlayerInfo.FindObjectOfType<PlayerInfo>();
        if (playerInfo == null) return;
        Destroy(playerInfo.transform.gameObject);
    }
}
