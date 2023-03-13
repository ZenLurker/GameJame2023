using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClientLogic: MonoBehaviour
{

    [SerializeField] PlayerCommand player;
    private int command_level = 0;
    private Command command;

    bool isHappy;


    // Start is called before the first frame update
    void Awake()
    {
        command_level = player.getScore();
        command = new Command(command_level);
        command.printCommand();
    }

    // Update is called once per frame
    void Update()
    {
        //command_level = player.getScore();
    }

    public Command getCommand() {
        return command;
    }

    public Command getCommand(int score) {
        return new Command(score);
    }


    public void IsHappy(bool status){
        isHappy = status;
    }
    
    public bool getIsHappy()
    {
        return isHappy;
    }
    
}
