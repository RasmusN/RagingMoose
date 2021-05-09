using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BraamSounds : MonoBehaviour
{
    public AudioSource braamAudio;
    public AudioClip[] braamList;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Obstacle"))
        {
            // could make it so it doesn't play new moose sound until last one has finished
            if (braamList.Length == 0) return;
            // choose random sound from list (int)
            int randomInt = Random.Range(0, braamList.Length - 1);

            // set that sound to source
            braamAudio.clip = braamList[randomInt];

            // play
            braamAudio.Play();
        }
    }
}
