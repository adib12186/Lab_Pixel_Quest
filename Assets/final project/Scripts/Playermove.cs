using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb; //physics
    private SpriteRenderer _spriteRenderer; //image
    public int speed = 4;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer= GetComponentInChildren<SpriteRenderer>();
    }

    
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
  Debug.Log(xInput);
        if (xInput < 0){ 
            Debug.Log("a");
            _spriteRenderer.flipX= true;
        }
         else if (xInput > 0){
            Debug.Log("ab");
            _spriteRenderer.flipX = false; 
        }
    }
}
