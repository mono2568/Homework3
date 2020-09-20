using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject ball1;
    // Start is called before the first frame update
    void Start()
    {
        ball1 = GameObject.Find("ball1");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ball1.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
    }
}
