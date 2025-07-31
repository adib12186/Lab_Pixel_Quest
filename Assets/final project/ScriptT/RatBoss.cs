using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatBoss : MonoBehaviour
{
    public int maxHealth = 100;
    public float moveSpeed = 2f;
    public Transform[] patrolPoints;

    private int currentPoint = 0;
    private int currentHealth;
    private bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (isDead || patrolPoints.Length == 0) return;

        // Patrol between points
        Transform targetPoint = patrolPoints[currentPoint];
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            currentPoint = (currentPoint + 1) % patrolPoints.Length;
        }
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        Debug.Log("Rat Boss defeated!");
        Destroy(gameObject); // or play animation, trigger cutscene, etc.
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Example: damage the player
            Debug.Log("Rat Boss hit the player!");
            // collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(10);
        }
    }
}


