using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommand : MonoBehaviour
{

    [SerializeField] ClientLogic client;
    private Command commandClient;
    private Command fulfillmentCommand;
    bool hasCommand = false;


    // Start is called before the first frame update
    void Start()
    {
        fulfillmentCommand = new Command();
    }   

    // Update is called once per frame
    void Update()
    {
        if(hasCommand){
            commandClient.printCommand();
        }else
            fulfillmentCommand.printCommand();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Client") && !hasCommand)
        {
            commandClient = client.getCommand();
            hasCommand = true;
        }
    }

}
