using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 10f;

    Vector2 moveInput;
    Rigidbody2D myRigidBody;
    Animator myAnimator;

    bool canMove = true;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
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

    public bool OnCheckCommands(InputValue value){
        if(value.isPressed){
            return true;
        }
        return false;
    }

    void Run()
    {
        if(canMove)
        {
            Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, moveInput.y * runSpeed);
            myRigidBody.velocity = playerVelocity;

            bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
            bool playerVerticalSpeed = Mathf.Abs(myRigidBody.velocity.y) > Mathf.Epsilon;

            if(playerHasHorizontalSpeed || playerVerticalSpeed){
                myAnimator.SetBool("isRunning", true);
            }
            else{
                myAnimator.SetBool("isRunning", false);
            }   
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
        
        myRigidBody.velocity = Vector2.zero;
    }

    public void startMovement()
    {
        canMove = true;
    }
}
