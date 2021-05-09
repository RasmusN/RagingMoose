using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXForestCollision : MonoBehaviour
{
    private AudioSource audioData;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play();
        }
        else
        {
            Debug.Log($"Hit an unknown object TAG #{other.tag}");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        audioData?.Stop();
    }
}
