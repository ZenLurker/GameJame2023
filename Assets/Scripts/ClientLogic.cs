using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClientLogic: MonoBehaviour
{

    [SerializeField] int command_level;
    private Command command;

   


    // Start is called before the first frame update
    void Start()
    {
      
        command = new Command(command_level);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Command getCommand() {
        return command;
    }


    

    
}
