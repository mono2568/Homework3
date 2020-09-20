using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private void Start()
    {
        camera2.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera1.enabled = false;
        camera2.enabled = true;
    }
}
