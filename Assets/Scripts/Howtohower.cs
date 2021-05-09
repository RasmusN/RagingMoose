using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howtohower : MonoBehaviour
{
    public GameObject HowToPlay;
    
    void OnMouseOver(){
        HowToPlay.SetActive(true);
        
    }
    void OnMouseExit(){
        HowToPlay.SetActive(false);
    }
}
