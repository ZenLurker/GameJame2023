using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 10f;

    Vector2 moveInput;
    Rigidbody2D myRigidBody;

    

    bool canMove = true;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Run();
        FlipSprite();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void Run()
    {
        if(canMove)
        {
            Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, moveInput.y * runSpeed);
            myRigidBody.velocity = playerVelocity;
        }
        
    }

    private void FlipSprite()
    {
        if(myRigidBody.velocity.x < 0){
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(myRigidBody.velocity.x > 0){
            transform.localScale = new Vector3(1, 1, 1);
            }
    }

    public void stopMovement()
    {
        canMove = false;
    }

    public void startMovement()
    {
        canMove = true;
    }
}