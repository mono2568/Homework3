using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager4 : MonoBehaviour
{
    public Camera camera4;
    public Camera camera5;

    public AudioSource audioSource;
    public double FadeOutSeconds = 1.0;
    bool IsFadeOut = false;
    double FadeDeltaTime = 0;

    private void Start()
    {
        camera5.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera4.enabled = false;
        camera5.enabled = true;
        IsFadeOut = true;
    }

    private void Update()
    {
        if (IsFadeOut)
        {
            FadeDeltaTime += Time.deltaTime;
            if (FadeDeltaTime < FadeOutSeconds)
            {
                audioSource.volume = (float)(1.0 - FadeDeltaTime / FadeOutSeconds);
            }
            else IsFadeOut = false;
            
        }
    }
}
