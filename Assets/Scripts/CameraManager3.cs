using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager3 : MonoBehaviour
{
    public Camera camera3;
    public Camera camera4;

    private void Start()
    {
        camera4.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera3.enabled = false;
        camera4.enabled = true;
    }
}
