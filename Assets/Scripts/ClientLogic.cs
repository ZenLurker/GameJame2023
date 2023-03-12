using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClientLogic: MonoBehaviour
{

    [SerializeField] int command_level;
    private Command command;

    bool isHappy;


    // Start is called before the first frame update
    void Awake()
    {
        command = new Command(command_level);
        command.printCommand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Command getCommand() {
        return command;
    }

    public void IsHappy(bool status){
        isHappy = status;
    }
    

    
}
