using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Command
{
    private ArrayList coffees = new ArrayList();
    public Command(int level)
    {
        int coffee_amount = UnityEngine.Random.Range(1, level + 1);
        for (int i = 0; i < coffee_amount; i++)
        {
            coffees.Add(new Coffee(level));
        }
    }

    public void printCommand()
    {
        foreach (Coffee coffee in coffees)
        {
            Debug.Log("Coffee with " + coffee.getSugars() + " sugars, and " + coffee.getCreams() + " creams.");
        }
    }

    public override bool Equals(object other) {
        if(!(other is Command)) {
            return false;
        }
        Command other_command = other as Command;
        if(coffees.Count != other_command.coffees.Count) {
            return false;
        }
        for(int i = 0; i < coffees.Count; i++) {
            if(!coffees[i].Equals(other_command.getCoffee(i))) {
                return false;
            }
        }
        return true;
    }

    public ArrayList getCoffees()
    {
        return coffees;
    }

    private Coffee getCoffee(int index) {
        return (Coffee) coffees[index];
    }
    private class Coffee
    {
        private int sugar = 0, cream = 0, espresso = 0, alcohol = 0;
        private bool punched = false, iced = false;
        public Coffee(int level)
        {

            if (level > 1)
            {
                punched = (UnityEngine.Random.Range(0, 2) == 1);
            }
            if (!punched && level > 2)
            {
                iced = (UnityEngine.Random.Range(0, 2) == 1);
            }
            if (level > 3)
            {
                espresso = UnityEngine.Random.Range(0, Math.Min(level, 3));
            }
            if (level > 4)
            {
                alcohol = UnityEngine.Random.Range(0, Math.Min(level, 3));
            }
            sugar = UnityEngine.Random.Range(0, Math.Min(level, 5));
            cream = UnityEngine.Random.Range(0, Math.Min(level, 5));


        }

        public override bool Equals(object other) {
            if(!(other is Coffee)) {
                return false;
            }
            Coffee other_coffee = other as Coffee;
            if(cream != other_coffee.getCreams()) {
                return false;
            } else if(sugar != other_coffee.getSugars()) {
                return false;
            } else if(espresso != other_coffee.getEspresso()) {
                return false;
            } else if(alcohol != other_coffee.getAlcohol()) {
                return false;
            } else if(punched != other_coffee.getPunched()) {
                return false;
            } else if(iced != other_coffee.getIced()) {
                return false;
            }
            return true;
        }

        

        public int getCreams()
        {
            return cream;
        }
        public int getSugars()
        {
            return sugar;
        }
        public int getEspresso()
        {
            return espresso;
        }
        public int getAlcohol()
        {
            return alcohol;
        }
        public bool getPunched()
        {
            return punched;
        }
        public bool getIced()
        {
            return iced;
        }
    }







}
