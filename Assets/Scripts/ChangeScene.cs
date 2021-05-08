using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void menuScene()
    {
        SceneManager.LoadScene(0);
        PlayerInfo pl;
        
    }
    public void gameScene()
    {
        SceneManager.LoadScene(1);
    }
    public void scoreScene()
    {
        SceneManager.LoadScene(2);
    }
}
