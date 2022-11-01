using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerBehavior : MonoBehaviour
{
    private PlayerController playerController;
    private InputAction moveAction;
    
    [SerializeField] float speed = 6.0f;
    
    public bool canPlay;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 0.01f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;


    private void Awake()
        {
            playerController = new PlayerController();
            controller = GetComponent<CharacterController>();
        }
    

    void Update()
    {

        Vector2 movementInput = playerController.Player.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(movementInput.x, movementInput.y, 0f);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        controller.Move(playerVelocity * Time.deltaTime);

    }
    
    private void OnEnable()
    {
        moveAction = playerController.Player.Move;
        moveAction.Enable();
    }

    public bool CanRun
    {
        get => canPlay;
        set => canPlay = value;
    }

    // Update is called once per frame
    /*void Update()
    {
        if(canPlay == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }

       
        }
            
    }
    */

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            canPlay = false;
        }
        
    }
}
