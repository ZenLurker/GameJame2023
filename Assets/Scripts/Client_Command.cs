using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client_Command : MonoBehaviour
{

    [SerializeField] int command_level;
    private Command command;

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

    public ArrayList getCommand() {
        return command.getCommand();
    }


    private class Coffee {
        private int sugar, cream;
        public Coffee(int level) {
            if(level <= 0) {
                sugar = 0;
                cream = 0;
            } else {
                sugar = UnityEngine.Random.Range(0,Math.Min(level, 4));
                cream = UnityEngine.Random.Range(0,Math.Min(level, 4));
            }
        }

        public int getCreams() {
            return cream;
        }
        public int getSugars() {
            return sugar;
        }
    }

    private class Command {
        private ArrayList coffees = new ArrayList();
        public Command(int level) {
            int coffee_amount = UnityEngine.Random.Range(1, level + 1);
            for(int i = 0; i < coffee_amount; i++) {
                coffees.Add(new Coffee(level));
            }
        }

        public void printCommand() {
            foreach(Coffee coffee in coffees) {
                Debug.Log("Coffee with " + coffee.getSugars() + " sugars, and " + coffee.getCreams() + " creams.");
            }
        }

        public ArrayList getCommand() {
            return coffees;
        }

        
    }

    
}
