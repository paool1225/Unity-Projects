using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDscript : MonoBehaviour
{
    public float MoveSeed;
    float moveX;
    float moveY;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveX = 0;
        moveY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveX * MoveSeed * Time.deltaTime, moveY * MoveSeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveY = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveY = -1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveX = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveX = 1;
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            moveY = 0;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            moveX = 0;
        }
    }
}
