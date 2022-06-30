using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    public float speed;
    float x;
    Vector2 move;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        move = new Vector2(x * speed, rb.velocity.y);
        rb.velocity = move;
    }
}
