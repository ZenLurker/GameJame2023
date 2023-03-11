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

        Command second_one = command;
        Debug.Log(second_one.Equals(command));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Command getCommand() {
        return command;
    }


    
}
