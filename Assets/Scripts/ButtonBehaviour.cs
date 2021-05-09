using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public Button btn;
    public AudioSource audioSrc;
    public GameObject HowToPlay;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(taskOnClick);
    }

    void taskOnClick()
    {
        audioSrc.Play();
        if(gameObject.tag == "howtoplay"){
            if(HowToPlay.activeSelf){
                HowToPlay.SetActive(false);
            } else {
                HowToPlay.SetActive(true);
            }
        }
    }
}
