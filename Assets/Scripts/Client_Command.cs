using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Client_Command : MonoBehaviour
{

    [SerializeField] int command_level;
    private Command command ;

    // Start is called before the first frame update
    void Start()
    {
        command = new Command(0);
        Debug.Log("Cafe 1:");
        command.printCommand();

        command = new Command(2);
        Debug.Log("Cafe 2:");
        command.printCommand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Command getCommand() {
        return command;
    }


    

    
}
