using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer _spriteRenderer;

    public int speed = 4;

    [Header("Dash Settings")]
    public float dashForce = 50f;
    public float dashCooldown = 30f;
    private float currentCooldown = 0f;
    private bool canDash = true;

    [Header("Slide Settings")]
    public float slideSpeed = 10f;
    public float slideDuration = 0.3f;
    private bool isSliding = false;
    private float slideTimer = 0f;

    private PlayerUIController uiController;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        uiController = GetComponent<PlayerUIController>();
        uiController.StartUI();
        uiController.UpdateDashCooldown(0); // show ready
    }

    void Update()
    {
        HandleMovement();
        HandleDash();
        HandleSlide();
    }

    void HandleMovement()
    {
        if (isSliding) return; // Don't allow normal movement during slide

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        if (xInput < 0)
            _spriteRenderer.flipX = true;
        else if (xInput > 0)
            _spriteRenderer.flipX = false;
    }

    void HandleDash()
    {
        if (Input.GetKey(KeyCode.X) && canDash && !isSliding)
        {
            float direction = _spriteRenderer.flipX ? -1f : 1f;
            rb.velocity = new Vector2(direction * dashForce, rb.velocity.y);
            canDash = false;
            currentCooldown = dashCooldown;
        }

        if (!canDash)
        {
            currentCooldown -= Time.deltaTime;
            uiController.UpdateDashCooldown(currentCooldown);

            if (currentCooldown <= 0)
            {
                canDash = true;
                currentCooldown = 0;
                uiController.UpdateDashCooldown(0);
            }
        }
    }

    void HandleSlide()
    {
        if (Input.GetKey(KeyCode.S) && !isSliding)
        {
            StartSlide();
        }

        if (isSliding)
        {
            slideTimer -= Time.deltaTime;
            if (slideTimer <= 0)
            {
                EndSlide();
            }
        }
    }

    void StartSlide()
    {
        isSliding = true;
        slideTimer = slideDuration;

        float direction = _spriteRenderer.flipX ? -1f : 1f;
        rb.velocity = new Vector2(direction * slideSpeed, rb.velocity.y);
    }

    void EndSlide()
    {
        isSliding = false;
    }
}
