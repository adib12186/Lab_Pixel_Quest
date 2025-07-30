using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _anim;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (_rb.velocity.x== 0)
        {
            _anim.SetBool("PlayerWalking", false);
        }
        else
        {
            _anim.SetBool("PlayerIdle", true);
        }
    }
}
