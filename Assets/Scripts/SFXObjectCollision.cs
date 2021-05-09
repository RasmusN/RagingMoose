using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXObjectCollision : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip[] soundList;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            // could make it so it doesn't play new moose sound until last one has finished
            if (soundList.Length == 0) return;
            // choose random sound from list (int)
            int randomInt = Random.Range(0, soundList.Length - 1);

            // set that sound to source
            audioSrc.clip = soundList[randomInt];

            // play
            audioSrc.Play();
        }
    }
}
