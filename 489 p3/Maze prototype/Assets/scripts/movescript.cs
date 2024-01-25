using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
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
        rb.velocity = new Vector2 (moveX * MoveSeed * Time.deltaTime, moveY * MoveSeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveY = 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveY = -1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveX = -1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveX = 1;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)) {
            moveY = 0;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            moveX = 0;
        }
    }

}
