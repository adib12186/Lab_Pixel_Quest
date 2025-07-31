using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
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
        if (_rb.velocity.x == 0)
        {
            _anim.SetBool("PlayerWalk", false);
            _anim.SetBool("PlayerIdle", true);
            _anim.SetBool("PlayerDash", false);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
           _anim.SetBool("PlayerWalk", false);
            _anim.SetBool("PlayerIdle", false);
            _anim.SetBool("PlayerDash", true); 
        }
        else
        {
            _anim.SetBool("PlayerWalk", true);
            _anim.SetBool("PlayerIdle", false);
            _anim.SetBool("PlayerDash", false);
        }
    }
}
