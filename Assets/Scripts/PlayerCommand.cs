using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommand : MonoBehaviour
{

    [SerializeField] ClientLogic client;
    private Command commandClient;
    private Command fulfillmentCommand;
    private PlayerMovement playerMovement;
    bool hasCommand = false;
    bool commandIsComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        fulfillmentCommand = new Command();
        playerMovement  = GetComponent<PlayerMovement>();
    }   

    // Update is called once per frame
    void Update()
    {
        if(hasCommand){
            commandClient.printCommand();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Client") && !hasCommand)
        {
            commandClient = client.getCommand();
            hasCommand = true;
        }

        if(other.gameObject.CompareTag("Client") && commandIsComplete && hasCommand){
            client.IsHappy(true);
            hasCommand = false;
        }

        if(other.gameObject.CompareTag("Client") && !commandIsComplete && hasCommand){
            client.IsHappy(false);
        }

        if(other.gameObject.CompareTag("Client")){
            
            StartCoroutine("waitBeforeMove");

        }

    }

    private IEnumerator waitBeforeMove()
    {
        playerMovement.stopMovement();
        yield return new WaitForSeconds(2);
        playerMovement.startMovement();
    }

}
