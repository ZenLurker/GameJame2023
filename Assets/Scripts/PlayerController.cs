using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    private ArrayList command;

    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    bool canMove = true;
    bool hasCommand = false;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
 
    void Update()
    {
        if(canMove){
            movePlayer();
        }
    }

    public void DisableControls(){
        canMove = false;
    }

    private void movePlayer(){
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0, -(moveSpeed * Time.deltaTime), 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-(moveSpeed * Time.deltaTime), 0, 0);

            spriteRenderer.flipX = true;  
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);

            spriteRenderer.flipX = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        //Receiving command
        if(hasCommand == false){
            if(other.gameObject.CompareTag("Command Zone")){
                //command = (Client)other.gameObject.getCommand();
            }
        }
    }
}
