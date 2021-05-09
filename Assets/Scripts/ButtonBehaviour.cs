using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public Button btn;
    public AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(taskOnClick);
    }

    void taskOnClick()
    {
        audioSrc.Play();
    }
}
