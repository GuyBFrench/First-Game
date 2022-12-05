using UnityEngine;
using UnityEngine.InputSystem;

public class MainShipController : MonoBehaviour
{
    public bool canRun;
    private Vector2 moveInput;
    private Rigidbody2D rb;
    public float moveSpeed = 25f; 

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }

    void FixedUpdate()
    {
        if (canRun)
        {
            rb.MovePosition(rb.position + moveInput * (moveSpeed * Time.fixedDeltaTime));
        }
        
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
