using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class RatCode : MonoBehaviour
{
    public Transform player;          // Reference to the player
    public float moveSpeed = 2f;      // How fast the rat moves

    void Update()
    {
        if (player != null)
        {
            // Move the rat towards the player
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                moveSpeed * Time.deltaTime
            );
        }
    }
}
