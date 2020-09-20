using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager2 : MonoBehaviour
{
    public Camera camera2;
    public Camera camera3;

    private void Start()
    {
        camera3.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera2.enabled = false;
        camera3.enabled = true;
    }
}
