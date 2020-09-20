using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCheckPoint : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
