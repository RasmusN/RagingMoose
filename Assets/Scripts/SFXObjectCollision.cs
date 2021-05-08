using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SFXObjectCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource audioData;

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
}
